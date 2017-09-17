using System;
using Xamarin.Forms;
using Xamvvm;

namespace Examples.Pages
{
    public class AppShell : MasterDetailPage, IBasePage<AppShellModel>
	{
		public AppShell()
		{
            Master = this.GetPageFromCache<MenuPageModel>() as Page;
            Detail = new NavigationPage(this.GetPageFromCache<MainPageModel>() as Page)
            {
                BarBackgroundColor = Color.FromHex("#DCDCDC"),
                Title = "Home Page"
            };
		}
	}
}
