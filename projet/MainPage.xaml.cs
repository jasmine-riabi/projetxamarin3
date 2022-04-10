using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet.Views;
using Xamarin.Forms;

namespace projet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void onClickMenu(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage, without passing any data.
            await Application.Current.MainPage.Navigation.PushModalAsync(new CountriesListPage());
        }
    }
}
