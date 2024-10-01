using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;

using Xamarin.Forms;

namespace DersUygulamasi5
{
    public class Page3 : ContentPage
    {
        public Page3()
        {
           StackLayout stc = new StackLayout();

           Assembly myA = Assembly.GetExecutingAssembly();
            Stream dosyam = myA.GetManifestResourceStream("DersUygulamasi5.DersListesi.txt");
            StreamReader sr = new StreamReader(dosyam);
            string line;
            int sindex = 0;
            while ((line = sr.ReadLine()) != null)
            {
                sindex++;
                if (sindex == 1)
                {
                    // ilk defa okuduk (başlık)
                    Label lblBaslik = new Label();
                    lblBaslik.Text = line;
                    lblBaslik.FontSize = Device.GetNamedSize(NamedSize.Title, lblBaslik);
                    lblBaslik.TextColor = Color.Red;
                    lblBaslik.FontAttributes = FontAttributes.Bold;
                    stc.Children.Add(lblBaslik);
                }
                else
                {
                    // başlık dışındaki metin satırları
                    Label lbl = new Label();
                    lbl.Text = line;
                    lbl.FontSize = Device.GetNamedSize (NamedSize.Medium, lbl);
                    stc.Children.Add(lbl);
                }

            }

            ScrollView s = new ScrollView();
            s.Content = stc;
            Content = s;
            Padding = new Thickness(10, 10, 10, 10);
        }
    }
}