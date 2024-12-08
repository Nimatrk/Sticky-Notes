using Sticky_Notes.UI.MVVM.Model;
using Sticky_Notes.UI.Repositories;

namespace Sticky_Notes.UI.Services;

public class NoteService
{
    private NoteRepository _noteRepository;

    public NoteService()
    {
        _noteRepository = new();
    }

    public bool AddNote(Note note) => _noteRepository.Add(note);

    public bool UpdateNote(Note note) => _noteRepository.Update(note);

    public bool DeleteNote(Note note) => _noteRepository.Delete(note);

    public IEnumerable<Note> GetNotes() => _noteRepository.GetAll();
}