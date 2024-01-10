

namespace MyFirstMobileApp.ViewViewModels.ControlContents.DatePickerContents.DatePickerVM;

public partial class DatePickerVMView : ContentPage
{
    public DatePickerVMView()
    {
        InitializeComponent();
        BindingContext = new DatePickerVMViewModel();
    }
}