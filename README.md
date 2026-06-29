# Desktop Productivity Tool

A C# desktop productivity tool skeleton for importing task data and generating a simple status report.

This repository is intentionally small. It is meant to show project structure and C# implementation style. It has been verified locally with .NET SDK 8.0.422.

## Features

- C# project structure.
- CSV task import example.
- Status summary model.
- Clear extension points for GUI or tray-app workflows.

## Tech Stack

- C#
- .NET 8 project file

## Run

```bash
dotnet run --project src/Ceenworks.DesktopTool
```

## Production Next Steps

- Add a desktop UI with WPF, WinUI, Avalonia, or Electron.NET.
- Add local settings storage.
- Add file picker workflows.
- Add export to Excel or PDF.
