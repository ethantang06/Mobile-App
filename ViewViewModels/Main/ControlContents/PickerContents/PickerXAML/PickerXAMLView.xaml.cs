namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerXAML;

public partial class PickerXAMLView : ContentPage
{
    public PickerXAMLView()
    {
        InitializeComponent();
        BindingContext = new PickerXAMLViewModel();
    }
}