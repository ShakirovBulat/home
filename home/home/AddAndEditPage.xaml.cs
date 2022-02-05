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
    public partial class AddAndEditPage : ContentPage
    {
        public AddAndEditPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Tapped", "Отмена", "Удалить");
        }
        //DisplayAlert("Alert", "Tapped", "OK");
    }
}