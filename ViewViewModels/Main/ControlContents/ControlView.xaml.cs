namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents;

public partial class ControlView : ContentPage
{
	public ControlView()
	{
		InitializeComponent();
		BindingContext = new ControlViewModel();
	}
}