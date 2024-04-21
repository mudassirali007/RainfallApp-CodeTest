# Rainfall Data Processing Application

## Overview
This C# console application reads rainfall data from CSV files, calculates the average rainfall over the last 4 hours for each device, and provides the status (Green, Amber, Red) based on specified thresholds. It also determines whether the rainfall trend for each device is increasing or decreasing.

## Requirements
- .NET SDK (Compatible with .NET Core 3.1 or later)
- Visual Studio Code or any preferred IDE with C# support
- CsvHelper library (for parsing CSV files)

## Setup Instructions

### 1. Install the .NET SDK
Download and install the .NET SDK from https://dotnet.microsoft.com/download.

### 2. Install Visual Studio Code
Download and install Visual Studio Code from https://code.visualstudio.com/. Ensure you also install the C# extension from Microsoft.

### 3. Clone the Project
Clone or download the project to your local machine. If provided in a zip file, extract it to your preferred directory.

### 4. Open the Project
Open Visual Studio Code and use 'File -> Open Folder' to open the project directory.

### 5. Restore and Build the Project
Open the integrated terminal in Visual Studio Code (Ctrl+`) and run the following commands:
   dotnet restore
   dotnet build
These commands will restore any NuGet packages and build the project, respectively.

## Running the Application

1. In the terminal, navigate to the project directory if not already there.
2. Run the command:
   dotnet run
3. Follow the prompts in the console:
   - Enter the path to the folder containing the rainfall data CSV files (e.g., C:\Data).
   - Enter the path to the Devices.csv file (e.g., C:\Data\Devices.csv).

## File Structure
- Data1.csv and Data2.csv should contain records in the format: Device ID, Time, Rainfall
  Example:
  Device ID,Time,Rainfall
  101,01/01/2021 12:00,5.2
- Devices.csv should contain device information in the format: Device ID, Device Name, Location
  Example:
  Device ID,Device Name,Location
  101,Device A,Town X

## Application Details

### Data Processing
The application calculates the average rainfall over the last 4 hours for each device and displays:
- Average rainfall
- Status based on the average:
  - Green: Average < 10mm
  - Amber: Average >= 10mm and < 15mm
  - Red: Average >= 15mm or any reading > 30mm in the last 4 hours
- Trend: Increasing, Decreasing, or Stable based on changes in the readings.

### Error Handling
Any errors related to file access or data format issues are logged in the console. Ensure CSV headers and formats are as expected.

## Maintenance and Extending the Application
The application can be extended by modifying the RainfallData and DeviceInfo classes to include additional data fields or by adjusting the data processing logic in RainfallProcessor.cs to accommodate new requirements or data sources.

Thank you for using the Rainfall Data Processing Application.
