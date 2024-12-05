using Sticky_Notes.UI.MVVM.Model;
using Sticky_Notes.UI.MVVM.View;
using System.Windows;
using System.Windows.Media;

namespace Sticky_Notes.UI.MVVM.ViewModel
{
    public class NoteViewModel : Core.ViewModel
    {
        private bool _editMode;
        private Note _note;

        public Note Note
        {
            get { return _note; }
            set { _note = value; OnPropertyChanged(); }
        }

        public Action OpenWindowAction;

        public NoteViewModel()
        {
            Note = new();
            OpenWindowAction += NoteViewModel_OpenWindowAction;
        }

        private void NoteViewModel_OpenWindowAction()
        {
            if (_editMode) return;
            _editMode = true;
            NoteView noteView = new() { DataContext = this};
            noteView.Closed += NoteView_Closed; 
            noteView.Show();
        }

        private void NoteView_Closed(object? sender, EventArgs e)
        {
            _editMode = false;
        }
    }
}