using home.MvvmModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectPage : ContentPage
    {
        private string path;
        public AddProjectPage(AddProjectViewModel projectViewModel)
        {
            InitializeComponent();
            BindingContext = projectViewModel;
        }
    }
}