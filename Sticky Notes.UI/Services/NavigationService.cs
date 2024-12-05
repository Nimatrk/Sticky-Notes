using Sticky_Notes.UI.Core;

namespace Sticky_Notes.UI.Services;

public class NavigationService : ObservableObject, INavigationService
{
    private ViewModel _currentView;
    private Func<Type, ViewModel> _viewmodelFactory;

    public ViewModel CurrentView
    {
        get => _currentView;
        private set { _currentView = value; OnPropertyChanged(); }
    }

    public NavigationService(Func<Type, ViewModel> viewModelFactory)
    {
        _viewmodelFactory = viewModelFactory;
    }

    public void NavigateTo<TViewModel>() where TViewModel : ViewModel
    {
        var vm = _viewmodelFactory.Invoke(typeof(TViewModel));
        CurrentView = vm;
    }
}
