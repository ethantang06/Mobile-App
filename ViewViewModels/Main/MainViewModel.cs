using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public String StackLayoutButtonTitle { get; set; } = TitleMain.ButtonStackLayout;
        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;
            
        }
    }
}
