namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.EntryContents;

public partial class EntryView : ContentPage
{
	public EntryView()
	{
		InitializeComponent();
        BindingContext = new EntryViewModel();
    }
}