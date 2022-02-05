using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new AddAndEditPage(), true);
        }


        async void OpenProject(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new Project1(), true);
        }
    }
}