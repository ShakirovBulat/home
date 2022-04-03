using home.MvvmModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectViewModel ViewModel { get; private set; }

        public EditProjectPage(EditProjectViewModel proj)
        {
            InitializeComponent();
            ViewModel = proj;
            this.BindingContext = proj;
        }
    }
}