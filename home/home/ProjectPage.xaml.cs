using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using home.db;
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
            UpdateList();
        }
        // обработка нажатия элемента в списке
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new AddAndEditPage(), true);
        }


        private async void ProjectsLstview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new Project1((ProjectModel)e.Item));
        }

        protected override void OnAppearing()
        {
            UpdateList();
            base.OnAppearing();
        }

        public void UpdateList()
        {
            ProjectsLstview.ItemsSource = null;
            ProjectsLstview.ItemsSource = App.Db.GetProjects();
        }
    }
}