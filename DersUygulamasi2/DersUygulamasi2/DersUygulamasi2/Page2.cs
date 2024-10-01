using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi2
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            Padding = new Thickness(20, 40, 20, 20);
            StackLayout disStackLayout = new StackLayout();
            disStackLayout.BackgroundColor = Color.Yellow;
            disStackLayout.Padding = new Thickness(10, 10, 10, 0);

            StackLayout icStackLayout = new StackLayout();
            icStackLayout.BackgroundColor = Color.Red;

            Label myLabel = new Label();
            myLabel.Text = "Hello Page2.2";
            myLabel.HorizontalOptions = LayoutOptions.Start;
            myLabel.TextColor = Color.Blue;
            icStackLayout.Children.Add(myLabel);

            Button myButton = new Button();
            myButton.Text = "Click Me-2!";
            myButton.BackgroundColor = Color.Aqua;

            disStackLayout.Children.Add(icStackLayout);
            disStackLayout.Children.Add(myButton);
            Content = disStackLayout;

            //Content = new StackLayout
            //{
            //    BackgroundColor = Color.Yellow,
            //    Padding = new Thickness(10, 10, 10, 0),
            //    Children =
            //    {
            //        new StackLayout()
            //        {
            //            BackgroundColor = Color.Red,
            //            Children =
            //            {
            //                new Label()
            //                {
            //                    Text = "Hello Page2!",
            //                    HorizontalOptions = LayoutOptions.Start,
            //                    TextColor = Color.Blue,
            //                }
            //            }

            //        },
            //        new Button()
            //        {
            //            Text = "Click Me!",
            //            BackgroundColor = Color.Aqua,
            //        }
            //    }
            //};
        }
    }
}