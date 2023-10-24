namespace MyFirstMobileApp.ViewViewModels.Main.ImagesContents.EmbeddedImagesContents;

public partial class EmbeddedImagesView : ContentPage
{
	public EmbeddedImagesView()
	{
		InitializeComponent();
        BindingContext = new EmbeddedImagesViewModel();
    }
}