using MyFirstMobileApp.ViewViewModels.ControlsCollection.DatePickerControl;

namespace MyFirstMobileApp.ViewViewModels.ControlContents.DatePickerContents;

public partial class DatePickerView : ContentPage
{
    public DatePickerView()
    {
        InitializeComponent();
        BindingContext = new DatePickerViewModel();
    }
}