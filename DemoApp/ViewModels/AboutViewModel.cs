﻿using System;
using System.Windows.Input;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace DemoApp
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(
                () => {
                    Crashes.GenerateTestCrash();
                    Device.OpenUri(new Uri("https://xamarin.com/platform"));
                    
                });
        }

        public ICommand OpenWebCommand { get; }
    }
}
