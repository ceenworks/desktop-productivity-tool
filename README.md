# Desktop Productivity Tool

A C# desktop productivity tool skeleton for importing task data and generating a simple status report.

This repository is intentionally small. It is meant to show project structure and C# implementation style. The .NET SDK is not installed in the current local environment, so this pass was not compiled locally.

## Features

- C# project structure.
- CSV task import example.
- Status summary model.
- Clear extension points for GUI or tray-app workflows.

## Tech Stack

- C#
- .NET 8 project file

## Run

After installing the .NET SDK:

```bash
dotnet run --project src/Ceenworks.DesktopTool
```

## Production Next Steps

- Add a desktop UI with WPF, WinUI, Avalonia, or Electron.NET.
- Add local settings storage.
- Add file picker workflows.
- Add export to Excel or PDF.
