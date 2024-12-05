using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticky_Notes.UI.MVVM.Model
{
    public interface INote
    {
        DateTime CreationDateTime { get; set; }
        string Text { get; set; }
        IEnumerable<string> Images { get; set; }
    }
}
