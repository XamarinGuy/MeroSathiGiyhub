using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace MeroSathi
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MeroSathi.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("8d56921e-719d-4476-84d4-6e410381d714", typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
