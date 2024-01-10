using MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerXAML;

namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.PickerContents.PickerXAML;

public partial class PickerXAMLView : ContentPage
{
    public PickerXAMLView()
    {
        InitializeComponent();
        BindingContext = new PickerXAMLViewModel();
    }
}