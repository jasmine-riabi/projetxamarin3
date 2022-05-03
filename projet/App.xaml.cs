using projet.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new MainPage());
            tabbedPage.Children.Add(new Page1());
            tabbedPage.Children.Add(new Page2());
            tabbedPage.Children.Add(new Page3());
            tabbedPage.Children.Add(new Page4());
            tabbedPage.Children.Add(new Page5());
            tabbedPage.Children.Add(new Page6());

            CarouselPage carousel = new CarouselPage();
            carousel.Children.Add(new MainPage());
            carousel.Children.Add(new Page1());
            carousel.Children.Add(new Page2());
            carousel.Children.Add(new Page3());
            carousel.Children.Add(new Page4());
            carousel.Children.Add(new Page5());
            carousel.Children.Add(new Page6());


            // MainPage = new MainPage();
            MainPage = new NavigationPage(tabbedPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
