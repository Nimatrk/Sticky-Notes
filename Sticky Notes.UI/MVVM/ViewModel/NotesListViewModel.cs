using Sticky_Notes.UI.Core;
using Sticky_Notes.UI.MVVM.View;
using Sticky_Notes.UI.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace Sticky_Notes.UI.MVVM.ViewModel;

public class NotesListViewModel : Core.ViewModel
{
    private INavigationService _navigation;
    private string? _searchText;
    private ObservableCollection<NoteViewModel> _notes;
    private NoteViewModel _selectedNote;

    public INavigationService Navigation
    {
        get { return _navigation; }
        set { _navigation = value; OnPropertyChanged(); }
    }
    public string? SearchText
    {
        get { return _searchText; }
        set { _searchText = value; OnPropertyChanged(); }
    }
    public ObservableCollection<NoteViewModel> Notes
    {
        get { return _notes; }
        set { _notes = value; OnPropertyChanged(); }
    }
    public NoteViewModel SelectedNote
    {
        get { return _selectedNote; }
        set { _selectedNote = value; OnPropertyChanged(); }
    }

    public Action OpenSelectedNoteWindowAction;
    public RelayCommand NavigateSettingsCommand { get; set; }
    public RelayCommand AddNoteCommand { get; set; }
    public RelayCommand ClearSearchCommand { get; set; }

    public NotesListViewModel(INavigationService navigation)
    {
        Navigation = navigation;
        Notes = new();
        OpenSelectedNoteWindowAction += OpenSelectedNoteWindow;
        NavigateSettingsCommand = new(o => { Navigation.NavigateTo<SettingsViewModel>(); });
        AddNoteCommand = new(o => AddNote());
        ClearSearchCommand = new(o => { SearchText = string.Empty; });
    }

    private void OpenSelectedNoteWindow()
    {
        SelectedNote.OpenWindowAction.Invoke();
    }

    private void AddNote()
    {
        NoteViewModel vm = new NoteViewModel();
        Notes.Add(vm);
        vm.OpenWindowAction.Invoke();
    }
}