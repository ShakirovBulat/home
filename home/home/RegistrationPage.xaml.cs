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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        

        //async void OpenGlobalModalPageButtonClicked(object sender, EventArgs e)
        //{
        //    await App.GlobalNavigation.PushModalAsync(new SecondPage(), true);
        //}
    }
}