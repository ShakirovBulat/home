using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Tapped", "OK");
        }
        async void OpenProject(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new Project1(), true);
        }
    }
}