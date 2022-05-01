using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        CountriesListViewModel vm;
        public Page5()
        {
            InitializeComponent();
            vm = new CountriesListViewModel();
            BindingContext = vm;
        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCountriesOceanie();
        }
    }
}