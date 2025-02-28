# YmapChecker - Compilation and Installation Guide

## Prerequisites
- Install **.NET Framework** (if not already installed).
- Ensure **Visual Studio** or **.NET SDK** is installed.

## Compilation and Installation

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
