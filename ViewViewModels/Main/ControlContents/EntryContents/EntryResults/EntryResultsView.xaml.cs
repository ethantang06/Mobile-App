namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.EntryContents.EntryResults;

public partial class EntryResultsView : ContentPage
{
    public EntryResultsView(string entryText)
    {
        InitializeComponent();
        BindingContext = new EntryResultsViewModel(entryText);
    }
}
