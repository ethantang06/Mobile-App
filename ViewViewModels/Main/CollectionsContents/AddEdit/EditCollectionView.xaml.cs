using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(EntityCollectionPage gameType)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		GameTitle.Text = gameType.NameofGame;
	}
}