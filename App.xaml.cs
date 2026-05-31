using Microsoft.UI.Xaml;

namespace WinTrayApp;

public partial class App : Application
{
    private Services.TrayService? _trayService;

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        _trayService = new Services.TrayService();
        _trayService.Initialize();

        var window = new MainWindow();
        window.Activate();
    }
}
