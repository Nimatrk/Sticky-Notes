using Sticky_Notes.UI.Core;

namespace Sticky_Notes.UI.MVVM.Model;

public class Note : ObservableObject, INote
{
	private DateTime _creationDateTime = DateTime.Now;
	private string? _text;
	private IEnumerable<string> _images;

	public DateTime CreationDateTime
    {
		get { return _creationDateTime; }
		set { _creationDateTime = value; OnPropertyChanged(); }
	}

	public string? Text
	{
		get { return _text; }
		set { _text = value; OnPropertyChanged(); }
	}

	public IEnumerable<string> Images
	{
		get { return _images; }
		set { _images = value; }
	}
}