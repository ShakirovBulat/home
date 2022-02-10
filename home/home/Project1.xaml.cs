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
    public partial class Project1 : TabbedPage
    {
        readonly ProjectModel project;
        public static string Name;
        protected override void OnAppearing()
        {
            FillInfo();
            base.OnAppearing();
        }
        public Project1(ProjectModel project)
        {
            this.project = project;
            Name = project.Name;
            InitializeComponent();
            FillInfo();
        }

        public void FillInfo()
        {
            NameProjLbl.Text = project.Name;
            ProjectDescriptionLbl.Text = project.Description;
            AddressLbl.Text = project.Adress;
            EmailLbl.Text = project.Email;
            TelephoneNumberLbl1.Text = project.PhoneNum;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditPage());
        }
        //DisplayAlert("Alert", "Tapped", "OK");
    }
}