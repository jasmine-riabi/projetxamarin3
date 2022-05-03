using System;
using System.Globalization;
using System.Windows.Input;
using projet.Service;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace projet.ViewModels
{
    public class CountryPageViewModel : BaseViewModel
    {
        string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        Uri flags;
        public Uri Flags
        {
            get { return flags; }
            set { SetProperty(ref flags, value); }
        }

        string capital;
        public string Capital
        {
            get { return capital; }
            set { SetProperty(ref capital, value); }
        }

        string population;
        public string Population
        {
            get { return population; }
            set { SetProperty(ref population, value); }
        }

        string currencies;
        public string Currencies
        {
            get { return currencies; }
            set { SetProperty(ref currencies, value); }
        }

        public CountryPageViewModel(Country c)
        {
            Name = c.Name.Common;
            Flags = c.Flags.Png;
            Capital = c.Capital[0];
            Population = c.Population.ToString("#,#", CultureInfo.InvariantCulture);
            try
            {
                Currencies = c.Currencies.Byn.Name;
            }
            catch (Exception ex)
            {
                Currencies = "Inconue";
            }

        }

        public ICommand OnButtonClickedCommand
        {
            get
            {
                return new Command(ButtonClicked);
            }
        }
        void ButtonClicked()
        {

            /*Application.Current.MainPage.DisplayAlert("wiki", "https://en.wikipedia.org/wiki/"+Name, "Ok");*/
            Browser.OpenAsync("https://en.wikipedia.org/wiki/" + Name);
        }
    }
}
