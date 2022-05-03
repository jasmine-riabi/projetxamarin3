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

        Uri flags;
        public Uri Flags
        {
            get { return flags; }
            set { SetProperty(ref flags, value); }
        }


        public CountryPageViewModel(Country c)
        {
            Name = c.Name.Common;
            Flags = c.Flags.Png;
        }
    }
}
