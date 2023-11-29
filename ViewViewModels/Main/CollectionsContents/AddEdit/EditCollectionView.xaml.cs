using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(EntityCollectionPage gameType)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		GameName.Text = gameType.NameofGame;
	}
}