using System.Collections.Generic;
using Xamarin.Forms;
using Xamvvm;

namespace Examples
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            var factory = new XamvvmFormsFactory(this);
            XamvvmCore.SetCurrentFactory(factory);

            factory.RegisterNavigationPage<AppShellNavigationPageModel>(() => this.GetPageFromCache<MainPageModel>());
            factory.RegisterMasterDetail<AppShellModel>(
                () => this.GetPageFromCache<AppShellMasterPageModel>(),
                () => this.GetPageFromCache<AppShellNavigationPageModel>());

            MainPage = this.GetPageFromCache<AppShellModel>() as Page;
        }

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
