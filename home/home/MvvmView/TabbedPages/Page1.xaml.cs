using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using home.Models;

namespace home.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(Project project)
        {
            InitializeComponent();

        }
    }
}