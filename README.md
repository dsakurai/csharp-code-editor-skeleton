# WinTrayApp (WinUI 3 skeleton)

This is a minimal WinUI 3 unpackaged project skeleton demonstrating a system tray icon and a simple main window.

Build/run (developer machine must have Windows App SDK and .NET SDK installed):

```powershell
dotnet build
dotnet run --project WinTrayApp\WinTrayApp.csproj
```

Notes:
- The tray uses `System.Windows.Forms.NotifyIcon` for simplicity in an unpackaged app.
- This is a starter; later steps will add MVVM, persistence, and clipboard features.
