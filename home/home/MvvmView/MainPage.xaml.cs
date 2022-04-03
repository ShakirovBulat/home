using home.MvvmModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ListProjectViewModel { Navigation = this.Navigation};
        }
    }
}