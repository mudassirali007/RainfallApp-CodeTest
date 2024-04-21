using System;
using System.Collections.Generic;
using System.Linq;

public class RainfallProcessor
{
    private readonly CsvDataLoader _loader;

    public RainfallProcessor(CsvDataLoader loader)
    {
        _loader = loader;
    }

    public void ProcessData(string dataFolderPath, string devicesFilePath)
    {
        var devices = _loader.LoadDeviceData(devicesFilePath);
        var rainfallData = _loader.LoadRainfallData(dataFolderPath);

        var latestTimestamp = rainfallData.Max(d => d.Timestamp);
        var recentData = rainfallData.Where(d => d.Timestamp > latestTimestamp.AddHours(-4)).ToList();

        var groupedData = recentData.GroupBy(d => d.DeviceId).Select(g => new
        {
            Device = devices.FirstOrDefault(dev => dev.DeviceId == g.Key),
            AverageRainfall = g.Average(x => x.RainfallAmount),
            MaxRainfall = g.Max(x => x.RainfallAmount),
            Status = GetStatus(g.Average(x => x.RainfallAmount), g.Max(x => x.RainfallAmount)),
            Trend = GetTrend(g.OrderBy(x => x.Timestamp).ToList())
        });

        foreach (var item in groupedData)
        {
            var deviceInfo = item.Device != null ? $"{item.Device.Name} at {item.Device.Location}" : "Unknown device";
            Console.WriteLine($"Device {item.Device.DeviceId} ({deviceInfo}): Average Rainfall: {item.AverageRainfall:F2}mm, Status: {item.Status}, Trend: {item.Trend}");
        }
    }

    private string GetStatus(double averageRainfall, double maxRainfall)
    {
        if (maxRainfall > 30 || averageRainfall >= 15)
            return "Red";
        if (averageRainfall >= 10 && averageRainfall < 15)
            return "Amber";
        return "Green";
    }

    private string GetTrend(List<RainfallData> data)
    {
        if (data.Count < 2)
            return "Stable";
        return data.Last().RainfallAmount > data.First().RainfallAmount ? "Increasing" : "Decreasing";
    }
}
