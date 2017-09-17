using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamvvm;
using Xamarin.Forms;

namespace Examples
{
    public class DemoListViewPageModel : BasePageModel
    {
        public ObservableCollection<DogsItemViewModel> DogViewModelList
        {
            get { return GetField<ObservableCollection<DogsItemViewModel>>(); }
            set { SetField(value); }
        }

        public ICommand NavigateCommand { get; set; }

        public DemoListViewPageModel()
        {
            DogViewModelList = new ObservableCollection<DogsItemViewModel>();

            DogViewModelList.Add(new DogsItemViewModel() { Name = "Rex", Race = "German Sheppard" });
            DogViewModelList.Add(new DogsItemViewModel() { Name = "Barney", Race = "Poodle" });
            DogViewModelList.Add(new DogsItemViewModel() { Name = "Jimmy", Race = "Beagle" });
            DogViewModelList.Add(new DogsItemViewModel() { Name = "Rob", Race = "Labrador" });

            NavigateCommand = BaseCommand.FromTask(_ => this.PushPageAsNewInstanceAsync<DetailPageModel>(vm => vm.Init("Goldenrod", Color.Goldenrod)));
        }
    }

    // Should be something that makes a bit of sense, so why not dogs
    public class DogsItemViewModel : BaseModel
    {
        string name;
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value); }
        }

        string race;
        public string Race
        {
            get { return race; }
            set { SetField(ref race, value); }
        }
    }
}