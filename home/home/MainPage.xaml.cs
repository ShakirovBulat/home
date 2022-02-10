using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace home
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void GoToRegPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage(), true);
        }
        async void OpenProjectsPageButtonClicked(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new ProjectPage(), true);
        }
    }
}
