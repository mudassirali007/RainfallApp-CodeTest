using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class CsvDataLoader
{
    public List<DeviceInfo> LoadDeviceData(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<DeviceInfoMap>();
            return csv.GetRecords<DeviceInfo>().ToList();
        }
    }

    public List<RainfallData> LoadRainfallData(string folderPath)
    {
        List<RainfallData> data = new List<RainfallData>();
        var csvFiles = Directory.GetFiles(folderPath, "Data*.csv");

        foreach (var file in csvFiles)
        {
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<RainfallDataMap>();
                data.AddRange(csv.GetRecords<RainfallData>());
            }
        }

        return data;
    }

    private class DeviceInfoMap : ClassMap<DeviceInfo>
    {
        public DeviceInfoMap()
        {
            Map(m => m.DeviceId).Name("Device ID");
            Map(m => m.Name).Name("Device Name");
            Map(m => m.Location).Name("Location");
        }
    }

    private class RainfallDataMap : ClassMap<RainfallData>
{
    public RainfallDataMap()
    {
        Map(m => m.DeviceId).Name("Device ID");
        // Ensure the format here matches the date format in your CSV file
        Map(m => m.Timestamp).Name("Time").TypeConverterOption.Format("MM/dd/yyyy H:mm");
        Map(m => m.RainfallAmount).Name("Rainfall");
    }
}

}
