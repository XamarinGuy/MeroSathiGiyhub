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
            AppCenter.Start("ed9db7b4-f41b-4196-b28a-7d54270faca1", typeof(Analytics), typeof(Crashes));
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
