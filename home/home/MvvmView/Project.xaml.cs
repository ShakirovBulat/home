﻿using home.MvvmModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : TabbedPage
    {

        public ProjectPage(ProjectViewModel project)
        {
            InitializeComponent();
            BindingContext = project;
        }

    }
}