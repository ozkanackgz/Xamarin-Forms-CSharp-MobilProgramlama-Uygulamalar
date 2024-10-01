using System;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulamasi3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string s = "\t\tYBS 3006 Mobil Programlama YBS 3006 Mobil Programlama \n\n\t\t\"YBS 3006 Mobil Programlama\" YBS 3006 Mobil ProgramlamaYBS 3006 Mobil Programlama YBS 3006 Mobil Programlama ";




            MainPage = new ContentPage
            {
                Padding = new Thickness(20, 40, 20, 20),
                Content = new Label()
                {
                    Text = s,
                    BackgroundColor = Color.Red,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    VerticalTextAlignment = TextAlignment.Start,
                    HorizontalTextAlignment = TextAlignment.Start,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    LineBreakMode = LineBreakMode.NoWrap
                }
            };
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
