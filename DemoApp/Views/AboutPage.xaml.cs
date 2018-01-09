using System;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Analytics.TrackEvent("AboutPage.OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Analytics.TrackEvent("AboutPage.OnDisappearing");

        }
    }
}
