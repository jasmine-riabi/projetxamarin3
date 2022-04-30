using System;
using System.Collections.Generic;
using projet.Service;
using projet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryPage : ContentPage
    {
        public CountryPage(Country c)
        {
            InitializeComponent();
            BindingContext = new CountryPageViewModel(c);
        }
    }
}
