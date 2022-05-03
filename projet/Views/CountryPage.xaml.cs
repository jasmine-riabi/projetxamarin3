using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using projet.Interfaces;
using projet.Library;
using projet.Models;
using projet.Service;
using projet.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryPage : ContentPage
    {
        /*        public CountryPage(Country c)
                {
                    InitializeComponent();
                    BindingContext = new CountryPageViewModel(c);
                }*/

        Countries countries = new Countries();
        public const string DatabaseFilename = "test.json";
        public int j = 0;
        public CountryPage(Countries countrySelected)
        {
            InitializeComponent();
            BindingContext = new CountryPageViewModel(countrySelected);
            countries = countrySelected;
            int nbVue = countrySelected.NombreVue;
            j = Preferences.Get("j", nbVue);
            
        }

        protected override void OnAppearing()
        {
            int newNbVue = countries.NombreVue;

            List<CountriesStat> data = new List<CountriesStat>();
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //File.Delete(FilePath);
            if (File.Exists(FilePath))
            {
                string jsondata = File.ReadAllText(FilePath);
                data = JsonConvert.DeserializeObject<List<CountriesStat>>(jsondata);

                if (data != null && data.Count > 0 && data.Any(co => co.NomPays == countries.Name))
                {
                    foreach (CountriesStat stat in data)
                    {
                        if (stat.NomPays == countries.Name)
                        {
                            stat.NombreVue++;
                        }

                        string output = JsonConvert.SerializeObject(data, Formatting.Indented);
                        File.WriteAllText(FilePath, output);
                    }

                }
                else
                {
                    CountriesStat stat = new CountriesStat();
                    stat.NomPays = countries.Name;
                   
                    stat.NombreVue = 1;

                    data.Add(stat);

                    string output = JsonConvert.SerializeObject(data, Formatting.Indented);
                    File.WriteAllText(FilePath, output);
                }
            }
            else
            {

                CountriesStat stat = new CountriesStat();
                stat.NomPays = countries.Name;
                stat.NombreVue = 1;

                List<CountriesStat> stats = new List<CountriesStat>();
                stats.Add(stat);

                string output = JsonConvert.SerializeObject(stats, Formatting.Indented);
                File.WriteAllText(FilePath, output);

                File.Create(FilePath);
            }

            newNbVue++;
            countries.NombreVue = newNbVue;
            //nombreVue.Text = countries.NombreVue.ToString();
            j = newNbVue;
            Preferences.Set("j", j);

            if (File.Exists(FilePath))
            {
                string jsondata = File.ReadAllText(FilePath);
                data = JsonConvert.DeserializeObject<List<CountriesStat>>(jsondata);
                nombreVue.Text = data.FirstOrDefault(co => co.NomPays == countries.Name)?.NombreVue + "";
            }

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        public static string FilePath {
            get {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }


        async void OnTextToSpeechServiceClicked(object sender, EventArgs e)
        {
            await DependencyService.Get<ITextToSpeechService>().SpeakAsync(lab.Text);
        }
    }
}
