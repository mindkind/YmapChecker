# YmapChecker - Analysis and Compilation Guide

## Overview
YmapChecker is a command-line tool designed to analyze `.ymap` files, commonly used in **FiveM** and **GTA V** map modifications. It checks whether the `.ymap` file is encrypted and extracts object coordinates to help developers debug and validate their custom maps.

### Features
- Detects whether a `.ymap` file is encrypted.
- Extracts object coordinates from the `.ymap` file.
- Useful for **FiveM** and **GTA V** modders.
- Cross-platform support (Windows, Linux, macOS).

## How to Use YmapChecker
### Running the Tool
To analyze a `.ymap` file, use the following command:
```sh
./YmapChecker my_map.ymap
```
Example output:
```
YMAP is not encrypted. Analyzing coordinates...
Object: X=-1386.4225, Y=-614.3209, Z=33.52186
```
This output shows that the `.ymap` file is readable and provides the coordinates of objects within the map.

## Compilation and Installation
### Prerequisites
- Install **.NET Framework** (if not already installed).
- Ensure **Visual Studio** or **.NET SDK** is installed.

### Using Visual Studio
1. Open `YmapChecker.sln` in **Visual Studio**.
2. Select the appropriate build configuration (**Debug** or **Release**).
3. Click on **Build** > **Build Solution** (`Ctrl + Shift + B`).
4. The compiled executable will be available in:
   - `bin/Debug/` (for debugging)
   - `bin/Release/` (for production)

### Using Command Line
1. Open a terminal or command prompt and navigate to the project directory:
   ```sh
   cd YmapChecker
   ```
2. Build the project using:
   ```sh
   dotnet build
   ```
3. The compiled executable will be located in:
   ```
   bin/Debug/netcoreappX.X/ (replace X.X with your .NET version)
   ```

### Windows
Download the prebuilt executable or compile it yourself:
```sh
   dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o bin/win-x64
```

### Linux
```sh
   dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true -o bin/linux-x64
```

### macOS
```sh
   dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -o bin/osx-x64
```

## Running the Compiled Application
1. After compilation, navigate to the output directory:
   ```sh
   cd bin/Debug/netcoreappX.X/
   ```
2. Run the executable:
   ```sh
   YmapChecker.exe
   ```
