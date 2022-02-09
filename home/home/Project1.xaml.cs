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
    public partial class Project1 : TabbedPage
    {
        public Project1()
        {
            InitializeComponent();
        }
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new EditPage(), true);
        }
        //DisplayAlert("Alert", "Tapped", "OK");
    }
}