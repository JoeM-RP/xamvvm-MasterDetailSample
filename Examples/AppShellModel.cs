using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;

namespace Examples
{
    public class AppShellModel : BasePageModel
    {
    }

    public class AppShellMasterPageModel : BasePageModel
    {
        public AppShellMasterPageModel()
        {
            DetailButtonCommand = BaseCommand.FromTask<string>((param) => DetailButtonCommandExecute(param));
        }

        async Task DetailButtonCommandExecute(string param)
        {
            var pageToPush = this.GetPageFromCache<DetailPageModel>();
            var currentPage = this.GetPageFromCache<MainPageModel>();
            
            await XamvvmCore.CurrentFactory.PushPageAsync<MainPageModel, DetailPageModel>(currentPage, pageToPush);
        }


        public ICommand DetailButtonCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public bool IsMenuVisible
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
    }

    public class AppShellNavigationPageModel : BasePageModel
    {

    }
}
