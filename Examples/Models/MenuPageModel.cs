using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;

namespace Examples
{
    public class MenuPageModel : BasePageModel
    {
		public ICommand Page1Command { get; set; }

		public ICommand Page2Command { get; set; }

        public MenuPageModel()
        {
			Page1Command = new BaseCommand((arg) =>
			{
                SetDetailPageFromMenu(this.GetPageFromCache<MainPageModel>());
			});

			Page2Command = new BaseCommand((arg) =>
			{
                SetDetailPageFromMenu(this.GetPageFromCache<DemoListViewPageModel>());
			});
        }

        private void SetDetailPageFromMenu(IBasePage<BasePageModel> page)
        {
			var masterDetailPage = this.GetPageFromCache<AppShellModel>();
			masterDetailPage.GetPageModel().SetDetail(page);
        }
    }
}
