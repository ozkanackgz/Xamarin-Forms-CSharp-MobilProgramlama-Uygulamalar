using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi5
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            BackgroundColor = Color.Pink;
            Content = new BoxView
            {
                Color = Color.Red,
                WidthRequest = 300,
                HeightRequest = 300,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                CornerRadius = 10,
                Opacity = 0.4,

            };
        }
    }
}