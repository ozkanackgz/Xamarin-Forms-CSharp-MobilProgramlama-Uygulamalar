using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulamasi2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage
            {
                Padding = new Thickness(20, 40, 20, 20),
                Content = new StackLayout
                {
                    BackgroundColor = Color.Yellow,
                    Padding = new Thickness(10, 10, 10, 0),
                    Children = {
                    new StackLayout()
                    {
                        BackgroundColor = Color.Red,
                        Children =
                        {
                            new Label()
                            {
                                Text = "Hello Runtime Page!",
                                HorizontalOptions = LayoutOptions.Start,
                                TextColor = Color.Blue,
                            }
                        }

                    },
                    new Button()
                    {
                        Text = "Click Me Runtime!",
                        BackgroundColor = Color.Aqua,
                    }
                }
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
