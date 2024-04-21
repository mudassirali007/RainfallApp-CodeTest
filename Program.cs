using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the path to the folder containing the rainfall data CSV files:");
        var dataPath = Console.ReadLine();
        Console.WriteLine("Enter the path to the Devices.csv file:");
        var devicesPath = Console.ReadLine();

        CsvDataLoader loader = new CsvDataLoader();
        RainfallProcessor processor = new RainfallProcessor(loader);
        processor.ProcessData(dataPath, devicesPath);
    }
}
