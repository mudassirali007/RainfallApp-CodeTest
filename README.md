# Rainfall Data Processing Application

## Overview
This C# console application reads rainfall data from CSV files, calculates the average rainfall over the last 4 hours for each device, and provides the status (Green, Amber, Red) based on specified thresholds. It also determines whether the rainfall trend for each device is increasing or decreasing.

## Requirements
- .NET SDK (Compatible with .NET Core 3.1 or later)
- Visual Studio Code or any preferred IDE with C# support
- CsvHelper library (for parsing CSV files)

## Setup Instructions

### 1. Install the .NET SDK
Download and install the .NET SDK from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

### 2. Install Visual Studio Code
Download and install Visual Studio Code from [https://code.visualstudio.com/](https://code.visualstudio.com/). Ensure you also install the C# extension from Microsoft.

### 3. Clone the Project
Clone or download the project to your local machine. If provided in a zip file, extract it to your preferred directory.

### 4. Open the Project
Open Visual Studio Code and use 'File -> Open Folder' to open the project directory.

### 5. Restore and Build the Project
Open the integrated terminal in Visual Studio Code (Ctrl+\`) and run the following commands:
```bash
dotnet restore
dotnet build


## Running the Application

Before running the application, ensure that your data files (`Data1.csv`, `Data2.csv`, and `Devices.csv`) are placed in accessible directories. Here are steps to run the application:

1. **Open the Terminal:**
   - Navigate to the project directory using the terminal or command prompt.

2. **Execute the Application:**
   - Run the application by typing the following command and pressing Enter:
     ```bash
     dotnet run
     ```

3. **Provide the Required Paths:**
   - The application will first ask for the path to the folder containing the rainfall data CSV files. Enter the full path to this folder. 
     - Example on Windows:
       ```
       Enter the path to the folder containing the rainfall data CSV files:
       C:\Users\YourUsername\Documents\RainfallApp\Data
       ```
     - Example on macOS or Linux:
       ```
       Enter the path to the folder containing the rainfall data CSV files:
       /Users/YourUsername/Documents/RainfallApp/Data
       ```
   - Next, the application will ask for the path to the `Devices.csv` file. Enter the full path to where this file is stored.
     - Example on Windows:
       ```
       Enter the path to the Devices.csv file:
       C:\Users\YourUsername\Documents\RainfallApp\Devices.csv
       ```
     - Example on macOS or Linux:
       ```
       Enter the path to the Devices.csv file:
       /Users/YourUsername/Documents/RainfallApp/Devices.csv
       ```

### Notes on Paths:
- Ensure that you replace `YourUsername` and other placeholders with actual user names and paths corresponding to where the files are stored on your machine.
- Be aware that paths are case-sensitive on Unix-like systems (macOS and Linux), so you must enter them exactly as they are on your file system.
