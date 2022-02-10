using home.db;
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
        private async void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void AddBtn_Clicked(object sender, EventArgs e)
        {
            List.Projects.Add(new ProjectModel(ProjectNameTxt.Text, ProjectDescriptionTxt.Text, TelNumber1Txt.Text, EmailTxt.Text, AddressTxt.Text));

            try
            {
                App.db.SaveItem(new ProjectModel(ProjectNameTxt.Text, ProjectDescriptionTxt.Text, TelNumber1Txt.Text, EmailTxt.Text, AddressTxt.Text));
            }
            catch
            {
                await DisplayAlert("Error", "Загрузка в базу данных неуспешно", "Ok");
            }

            await Navigation.PopAsync();

        }
    }
}