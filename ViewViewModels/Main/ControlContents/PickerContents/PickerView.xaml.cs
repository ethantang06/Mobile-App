using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents;

namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents;

public partial class PickerView : ContentPage
{
    public PickerView()
    {
        InitializeComponent();
        BindingContext = new PickerViewModel();
    }
}