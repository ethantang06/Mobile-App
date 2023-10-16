namespace MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.FlexLayoutContents;

public partial class FlexLayoutView : ContentPage
{
	public FlexLayoutView()
	{
		InitializeComponent();
        BindingContext = new FlexLayoutViewModel();
    }
}