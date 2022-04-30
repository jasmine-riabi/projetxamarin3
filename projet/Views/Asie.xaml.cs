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
    public partial class Page4 : ContentPage
    {
        CountriesListViewModel vm;
        public Page4()
        {
            InitializeComponent();
            vm = new CountriesListViewModel();
            BindingContext = vm;
        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCountriesAsia();
        }
    }
}