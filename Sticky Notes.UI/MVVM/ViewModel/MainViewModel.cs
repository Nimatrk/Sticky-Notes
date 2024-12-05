using Sticky_Notes.UI.Core;
using Sticky_Notes.UI.Services;

namespace Sticky_Notes.UI.MVVM.ViewModel;

public class MainViewModel : Core.ViewModel
{
    private INavigationService _navigation;

    public INavigationService Navigation
    {
        get { return _navigation; }
        set { _navigation = value; OnPropertyChanged(); }
    }

    public MainViewModel(INavigationService navigation)
    {
        Navigation = navigation;
        Navigation.NavigateTo<NotesListViewModel>();
    }
}