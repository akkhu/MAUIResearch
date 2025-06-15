using Microsoft.UI.Xaml;

namespace AnnotationApp;

public partial class App : MauiWinUIApplication
{
    public App() : base()
    {
        this.InitializeComponent();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
