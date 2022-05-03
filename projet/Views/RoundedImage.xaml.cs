using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoundedImage : ContentView
    {
     public RoundedImage()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(ImageSource),
            typeof(RoundedImage), null, propertyChanged: (bindable, oldValue, newvalue)
            =>
            {
                if (newvalue is ImageSource image && bindable is RoundedImage)
                {
                    ((RoundedImage)bindable).image.Source = (ImageSource)newvalue;
                }
            });

        public static readonly BindableProperty SizeProperty = BindableProperty.Create(nameof(Size), typeof(Double),
            typeof(RoundedImage), null, propertyChanged: (bindable, oldValue, newvalue)
            =>
            {
                if (newvalue is Double frame && bindable is RoundedImage)
                {
                    ((RoundedImage)bindable).frame.HeightRequest = (float)(Double)newvalue;
                    ((RoundedImage)bindable).frame.WidthRequest = (float)(Double)newvalue;
                    ((RoundedImage)bindable).frame.CornerRadius = (float)(Double)newvalue / 2;

                }
            });

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public Double s
        {
            get { return (Double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }
    }
}