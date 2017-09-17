using System;
using Xamarin.Forms;
using Xamvvm;

namespace Examples
{
    public class AppShellModel : BasePageModel
    {
        public AppShellModel()
        {
        }

		public void SetDetail<TPageModel>(IBasePage<TPageModel> page) where TPageModel : class, IBasePageModel
		{
			var masterDetailPage = this.GetCurrentPage() as MasterDetailPage;

            // If we have set a custom Navbar color in AppShell.cs, we need to preserve it
            masterDetailPage.Detail = new NavigationPage(page as Page)
            {
                BarBackgroundColor = Color.FromHex("#DCDCDC")
            };

			masterDetailPage.IsPresented = false;
		}
    }
}
