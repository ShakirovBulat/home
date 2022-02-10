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
    public partial class EditPage : ContentPage
    {
        readonly ProjectModel project;
        public EditPage()
        {
            InitializeComponent();
        }
        public EditPage(ProjectModel proj)
        {
            project = proj;
            FillFields();
            InitializeComponent();
        }


        public void FillFields()
        {
            ProjName.Text = project.Name;
            DescriptionProj.Text = project.Description;
            PhonNumbProj.Text = project.PhoneNum;
            EmailProj.Text = project.Email;
            AdressProj.Text = project.Adress;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Изменение", $"Вы точно хотите удалить {project.Name}?", "УДАЛИТЬ", "ОТМЕНА");
            if (result == true)
            {
                try
                {
                    App.db.DelProj(project.Id);
                }
                catch
                {
                    await DisplayAlert("Error", "Загрузка в базу данных неуспешно", "Ok");
                }
                await Navigation.PopAsync();
            }
        }
        //DisplayAlert("Alert", "Tapped", "OK");
        private async void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void EditBtn_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Изменение", $"Вы точно хотите изменить {project.Name}?", "ИЗМЕНИТЬ", "ОТМЕНА");

            if (result)
            {
                project.Name = ProjName.Text;
                project.Description = DescriptionProj.Text;
                project.PhoneNum = PhonNumbProj.Text;
                project.Adress = AdressProj.Text;
                project.Email = EmailProj.Text;

                try
                {
                    App.db.SaveItem(project);
                }
                catch
                {
                    await DisplayAlert("Error", "Загрузка в базу данных неуспешно", "Ok");
                }

                await Navigation.PopAsync();
            }
        }
    }
}