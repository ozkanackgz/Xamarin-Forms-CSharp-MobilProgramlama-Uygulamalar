using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;
using System.Reflection;

namespace DersUygulamasi5
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            StackLayout stc = new StackLayout();
            foreach (var myColor in typeof(Color).GetRuntimeFields())
            {
                if (myColor.GetCustomAttributes<ObsoleteAttribute>() != null)
                    continue;
                if (myColor.IsPublic && myColor.IsStatic && myColor.FieldType == typeof(Color))
                {
                    StackLayout stcRenk = new StackLayout();
                    stcRenk.Children.Add(new BoxView()
                    {
                        WidthRequest = 20,
                        HeightRequest = 20,
                        CornerRadius = 10,
                        Color = (Color)myColor.GetValue(null),
                        Opacity = 1
                    });
                    stcRenk.Children.Add(new Label()
                    {
                        Text = myColor.Name
                    });
                    stcRenk.Children.Add(new Label()
                    {
                        Text = "( R : " + Convert.ToInt32( ((Color)myColor.GetValue(null)).R * 255 ) +
                               ", G : " + Convert.ToInt32( ((Color)myColor.GetValue(null)).G * 255 ) +
                               ", B : " + Convert.ToInt32( ((Color)myColor.GetValue(null)).G * 255 ) + " )"
                    }); ;
                    stcRenk.Orientation = StackOrientation.Horizontal;
                    stc.Children.Add(stcRenk);
                }
               
            }
            
            
            ScrollView s = new ScrollView();
            s.Content = stc;
            s.HorizontalOptions = LayoutOptions.Center;
            Content = s;
        }
    }
}