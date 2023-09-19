using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;
            Button = ButtonText.ButtonName;
        }
    }
}
