using Microsoft.Extensions.DependencyInjection;
using Sticky_Notes.UI.Core;
using Sticky_Notes.UI.MVVM.ViewModel;
using Sticky_Notes.UI.Services;
using System.Windows;

namespace Sticky_Notes.UI;

public partial class App : Application
{
    private ServiceProvider _serviceProvider;

    public App()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddTransient<MainWindow>(provider => new MainWindow()
        {
            DataContext = provider.GetRequiredService<MainViewModel>()
        });
        services.AddTransient<MainViewModel>();
        services.AddSingleton<NotesListViewModel>();
        services.AddSingleton<SettingsViewModel>();
        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<Func<Type, ViewModel>>(provider => vmType => (ViewModel)provider.GetRequiredService(vmType));

        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainView = _serviceProvider.GetRequiredService<MainWindow>();
        mainView.Show();
        base.OnStartup(e);
    }
}
