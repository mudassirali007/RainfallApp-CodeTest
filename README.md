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
