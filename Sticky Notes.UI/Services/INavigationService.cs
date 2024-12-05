using Sticky_Notes.UI.Core;

namespace Sticky_Notes.UI.Services;

public interface INavigationService
{
    ViewModel CurrentView { get; }
    void NavigateTo<T>() where T : ViewModel;
}
