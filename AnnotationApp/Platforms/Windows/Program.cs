using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.Maui;

namespace AnnotationApp;

public static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        var app = MauiWinUIApplication.Current;
        app.Run(args);
    }
}
