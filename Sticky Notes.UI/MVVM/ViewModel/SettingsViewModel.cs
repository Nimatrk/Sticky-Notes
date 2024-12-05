using Sticky_Notes.UI.Core;
using Sticky_Notes.UI.Services;

namespace Sticky_Notes.UI.MVVM.ViewModel;

public class SettingsViewModel : Core.ViewModel
{
    private INavigationService _navigation;

    public INavigationService Navigation
    {
        get { return _navigation; }
        set { _navigation = value; OnPropertyChanged(); }
    }

    public RelayCommand NavigateNotesListCommand { get; set; }

    public SettingsViewModel(INavigationService navigation)
    {
        Navigation = navigation;
        NavigateNotesListCommand = new(o => NavigateNotesList());
    }

    private void NavigateNotesList()
    {
        Navigation.NavigateTo<NotesListViewModel>();
    }
}