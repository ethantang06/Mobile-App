namespace MyFirstMobileApp.ViewViewModels.ControlContents.PickerContents.PickerVM;

public partial class PickerVMView : ContentPage
{
    public PickerVMView()
    {
        InitializeComponent();
        BindingContext = new PickerVMViewModel();
    }
}