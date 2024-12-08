using Sticky_Notes.UI.MVVM.Model;
using Sticky_Notes.UI.MVVM.View;
using Sticky_Notes.UI.Services;
using System.Windows;

namespace Sticky_Notes.UI.MVVM.ViewModel;

public class NoteViewModel : Core.ViewModel
{
    private bool _editMode;
    private Note _note;
    private NoteService _noteService;

    public Note Note
    {
        get { return _note; }
        set { _note = value; OnPropertyChanged(); }
    }

    public event Action SaveChangesAction;
    public Action OpenWindowAction;

    public NoteViewModel(Note note)
    {
        Note = note;
        _noteService = new NoteService();
        OpenWindowAction += NoteViewModel_OpenWindowAction;
        SaveChangesAction += NoteViewModel_SaveChangesAction;
    }

    private void NoteViewModel_OpenWindowAction()
    {
        if (_editMode) return;
        _editMode = true;
        NoteView noteView = new() { DataContext = this };
        noteView.Closed += NoteView_Closed;
        noteView.Show();
    }

    private void NoteView_Closed(object? sender, EventArgs e)
    {
        _editMode = false;
        SaveChangesAction?.Invoke();
    }

    private void NoteViewModel_SaveChangesAction()
    {
        var res = _noteService.UpdateNote(Note);
    }

}