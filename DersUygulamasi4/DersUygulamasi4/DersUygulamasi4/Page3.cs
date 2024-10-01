using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi4
{
    public class Page3 : ContentPage
    {

        class Renk
        {
            public Color RenkDegeri;
            public string RenkAdi;
        }

        public Page3()
        {
            List<Renk> renkler = new List<Renk>();
            renkler.Add(new Renk() { RenkAdi = "Beyaz", RenkDegeri = Color.White });
            renkler.Add(new Renk() { RenkAdi = "Siyah", RenkDegeri = Color.Black });
            renkler.Add(new Renk() { RenkAdi = "Kırmızı", RenkDegeri = Color.Red });
            renkler.Add(new Renk() { RenkAdi = "Sarı", RenkDegeri = Color.Yellow });
            renkler.Add(new Renk() { RenkAdi = "Mavi", RenkDegeri = Color.Blue });
            renkler.Add(new Renk() { RenkAdi = "Siyah", RenkDegeri = Color.Black });
            renkler.Add(new Renk() { RenkAdi = "Kırmızı", RenkDegeri = Color.Red });
            renkler.Add(new Renk() { RenkAdi = "Sarı", RenkDegeri = Color.Yellow });
            renkler.Add(new Renk() { RenkAdi = "Mavi", RenkDegeri = Color.Blue });
            renkler.Add(new Renk() { RenkAdi = "Siyah", RenkDegeri = Color.Black });
            renkler.Add(new Renk() { RenkAdi = "Kırmızı", RenkDegeri = Color.Red });
            renkler.Add(new Renk() { RenkAdi = "Sarı", RenkDegeri = Color.Yellow });
            renkler.Add(new Renk() { RenkAdi = "Mavi", RenkDegeri = Color.Blue });
            renkler.Add(new Renk() { RenkAdi = "Siyah", RenkDegeri = Color.Black });
            renkler.Add(new Renk() { RenkAdi = "Kırmızı", RenkDegeri = Color.Red });
            renkler.Add(new Renk() { RenkAdi = "Sarı", RenkDegeri = Color.Yellow });
            renkler.Add(new Renk() { RenkAdi = "Mavi", RenkDegeri = Color.Blue });

            StackLayout stc = new StackLayout();
            stc.BackgroundColor = Color.Azure;
            foreach (var item in renkler)
            {
                Label lbl = new Label();
                lbl.Text = item.RenkAdi;
                lbl.TextColor = item.RenkDegeri;
                lbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
                stc.Children.Add(lbl);
            }
            stc.Spacing = 40;
            stc.Orientation = StackOrientation.Vertical;
            
            ScrollView sview= new ScrollView();
            sview.Content = stc;
            sview.Orientation = ScrollOrientation.Vertical;

            Content = sview;

        }
    }
}