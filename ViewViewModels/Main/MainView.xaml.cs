using MyFirstMobileApp.ViewViewModels.Main.StackLayoutContents;

namespace MyFirstMobileApp.ViewViewModels.Main;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}