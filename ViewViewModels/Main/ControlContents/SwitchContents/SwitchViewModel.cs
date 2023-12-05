using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.SwitchContents
{
    public class SwitchViewModel : BaseViewModel
    {
        public bool Label1 { get; set; } = true;
        public bool Label2 { get; set; } = false;

        public SwitchViewModel()
        {

            Title = TitleSwitch.SwitchTitle;

        }
    }
}