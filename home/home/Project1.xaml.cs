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
    public partial class Project1
    {
        readonly ProjectModel project;
        public static string NameTit;
        protected override void OnAppearing()
        {
            FillInfo();
            base.OnAppearing();
        }
        public Project1(ProjectModel project)
        {
            this.project = project;
            NameTit = project.Name;
            InitializeComponent();
            FillInfo();
        }

        public void FillInfo()
        {
            ProjectDescriptionLbl.Text = project.Description;
            AddressLbl.Text = project.Adress;
            EmailLbl.Text = project.Email;
            TelephoneNumberLbl1.Text = project.PhoneNum;
            img.Source = project.Image;
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditPage(project));
        }
    }
}