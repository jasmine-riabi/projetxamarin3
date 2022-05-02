using System;
using projet.Service;

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


        public CountryPageViewModel(Country c)
        {
            Name = c.Name.Common;
        }
    }
}
