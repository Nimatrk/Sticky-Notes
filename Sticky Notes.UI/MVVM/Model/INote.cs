namespace Sticky_Notes.UI.MVVM.Model;

public interface INote
{
    public string ID { get; set; }

    string CreationDateTime { get; set; }

    string Text { get; set; }

    string Images { get; set; }
}