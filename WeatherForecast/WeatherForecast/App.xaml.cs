﻿using System;
using WeatherForecast.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherForecast
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}