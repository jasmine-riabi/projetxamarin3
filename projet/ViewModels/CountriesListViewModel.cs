using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using projet.Models;
using projet.Service;
using projet.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace projet.ViewModels
{
    public class CountriesListViewModel : BaseViewModel
    {
        private bool isLoading;
        public bool like;

        public bool IsLoading
        {
            get { return isLoading; }
            set { isLoading = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Country> countries; //= new ObservableCollection<Country>();

        public ObservableCollection<Country> Countries
        {
            get { return countries; }
            set { countries = value; OnPropertyChanged(); }
        }

        Country countrySelected;
        public Country CountrySelected
        {
            get { return countrySelected; }
            set
            {
                
                SetProperty(ref countrySelected, value);
                if (value != null)
                {
                    Countries countriesSelected = new Countries()
                    {
                        Like = false,
                        NombreVue = 1,
                        Name = value.Name.Common,
                    };

                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new CountryPage(countriesSelected));
                        CountrySelected = null;
                    });
                }
            }
        }


        public async Task LoadCountriesEurope()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesEurope();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;

            foreach (var t in Countries)
            {
                if (Preferences.ContainsKey(t.Name.ToString()))
                {
                    var myValue = Preferences.Get(t.Name.ToString(), true);
                    t.Like = myValue;
                }
                else
                {
                    t.Like = false;
                }
            }
        }

        public async Task LoadCountriesAsia()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesAsia();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;
        }

        public async Task LoadCountriesAfrique()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesAfrique();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;
        }

        public async Task LoadCountriesAmerique()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesAmerique();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;
        }

        public async Task LoadCountriesOceanie()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesOceanie();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;
        }

        public async Task LoadCountriesAntartic()
        {

            IsLoading = true;

            var countries = await CountriesService.GetCountriesAntartic();
            if (countries is IEnumerable<Country> tempCountries)
                Countries = new ObservableCollection<Country>(tempCountries);

            IsLoading = false;
        }

        public bool Like {
            get { return like; }
            set { SetProperty(ref like, value); }
        }
    }
}

