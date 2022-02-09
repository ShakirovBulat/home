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
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ProjectModel selectedFriend = (ProjectModel)e.SelectedItem;
            ProjectPage friendPage = new ProjectPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            ProjectModel friend = new ProjectModel();
            ProjectPage friendPage = new ProjectPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new AddAndEditPage(), true);
        }


        async void OpenProject(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushAsync(new Project1(), true);
        }
    }
}