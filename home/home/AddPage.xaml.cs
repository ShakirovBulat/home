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
        //private async void Save(object sender, EventArgs e)
        //{
        //    var project = (ProjectModel)BindingContext;
        //    if (!String.IsNullOrEmpty(project.Name))
        //    {
        //        App.db.SaveItem(project);
        //    }
        //    await this.Navigation.PopAsync();
        //}
    }
}