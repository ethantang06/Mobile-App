namespace MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents.HorizontalLayoutContents;

public partial class HorizontalLayoutView : ContentPage
{
	public HorizontalLayoutView()
	{
		InitializeComponent();
        BindingContext = new HorizontalLayoutViewModel();
    }
}