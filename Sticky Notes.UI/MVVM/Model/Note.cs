using Sticky_Notes.UI.Core;

namespace Sticky_Notes.UI.MVVM.Model;

public class Note : ObservableObject, INote
{
	private DateTime _date;
	private string? _text;
	private IEnumerable<string> _images;

	public DateTime CreationDateTime
    {
		get { return _date; }
		set { _date = value; OnPropertyChanged(); }
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