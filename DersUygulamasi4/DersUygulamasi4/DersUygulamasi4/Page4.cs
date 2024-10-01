using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi4
{
    public class Page4 : ContentPage
    {
        public Page4()
        {
            Content = new Frame
            {
                BorderColor = Color.Black,
                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 20,
                HasShadow = false,
                Content = new Label
                {
                    Text = "Merhaba, ben bir çerçeveyim!",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Blue
                }
            };
        }
    }
}