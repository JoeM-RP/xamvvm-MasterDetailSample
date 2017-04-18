using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;

namespace Examples.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellMasterPage : ContentPage, IBasePage<AppShellMasterPageModel>
    {
        public AppShellMasterPage()
        {
            InitializeComponent();
        }
    }
}
