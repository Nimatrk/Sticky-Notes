using Sticky_Notes.UI.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sticky_Notes.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for NotesListView.xaml
    /// </summary>
    public partial class NotesListView : UserControl
    {
        public NotesListView()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = DataContext as NotesListViewModel;
            vm.OpenSelectedNoteWindowAction.Invoke();
        }
    }
}
