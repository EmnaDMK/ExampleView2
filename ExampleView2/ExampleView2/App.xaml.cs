using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ExampleView2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new ExampleView2.MainPage();
            MainPage = new ExampleView2.Master();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes F
		}
	}
}
