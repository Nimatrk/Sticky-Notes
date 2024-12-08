using Sticky_Notes.UI.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sticky_Notes.UI.MVVM.Model;

[Table("Notes")]
public class Note : ObservableObject, INote
{
    private string _id;
    private string _creationDateTime = DateTime.Now.ToString();
    private string? _text;
    private string _images;

    [Key]
    public string ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }

    [Column("Date")]
    public string CreationDateTime
    {
        get { return _creationDateTime; }
        set { _creationDateTime = value; OnPropertyChanged(); }
    }

    [Column("Text")]
    public string? Text
    {
        get { return _text; }
        set { _text = value; OnPropertyChanged(); }
    }

    [Column("Images")]
    public string Images
    {
        get { return _images; }
        set { _images = value; OnPropertyChanged(); }
    }
}