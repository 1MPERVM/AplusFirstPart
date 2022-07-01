﻿using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using AplusXamarinApp.Page;


namespace AplusXamarinApp
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
