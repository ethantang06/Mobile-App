﻿using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Main.ControlContents.StepperContents
{
    public class StepperViewModel : BaseViewModel
    {
        public StepperViewModel()
        {
            Title = TitleStepper.StepperTitle;
        }
    }
}