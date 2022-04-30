using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet.Views
{
    [DesignTimeVisible(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        CountriesListViewModel vm;
        public Page1()
        {
            InitializeComponent();
            vm = new CountriesListViewModel();
            BindingContext = vm;
        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCountriesEurope();
        }
    }
}

