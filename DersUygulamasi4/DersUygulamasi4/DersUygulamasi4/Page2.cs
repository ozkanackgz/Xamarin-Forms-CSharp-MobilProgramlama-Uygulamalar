using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi4
{
    public class Page2 : ContentPage
    {

        NamedSize[] boyutlar = new NamedSize[]
        {
            NamedSize.Default,
            NamedSize.Micro,
            NamedSize.Small,
            NamedSize.Medium,
            NamedSize.Large,
            NamedSize.Body,
            NamedSize.Header,
            NamedSize.Title,
            NamedSize.Subtitle,
        };

        public Page2()
        {



            //Label lbl = new Label();

            //FormattedString str = new FormattedString();
            //Span sp1 = new Span();
            //sp1.Text = "I " + Environment.NewLine;
            //sp1.TextColor = Color.White;
            //sp1.FontSize = 30;
            //str.Spans.Add(sp1);

            //Span sp2 = new Span();
            //sp2.Text = "LOVE " + Environment.NewLine;
            //sp2.TextColor = Color.Red;
            //sp2.FontSize = 60;
            //str.Spans.Add(sp2);

            //Span sp3 = new Span();
            //sp3.Text = "XAMARİN! " + Environment.NewLine;
            //sp3.TextColor = Color.Violet;
            //sp3.FontSize = 30;
            //str.Spans.Add(sp3);

            //lbl.BackgroundColor = Color.Black;
            //lbl.FormattedText = str;
            //lbl.HorizontalOptions = LayoutOptions.Center;
            //lbl.HorizontalTextAlignment = TextAlignment.Center;

            //Content = lbl;

            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "I" + Environment.NewLine,
                            TextColor = Color.Black,
                            FontSize = 30,
                        },
                        new Span
                        {
                            Text = "LOVE" + Environment.NewLine,
                            TextColor = Color.Red,
                            FontSize = 60
                        },
                        new Span
                        {
                            Text = "Xamarin!",
                            TextColor = Color.Violet,
                            FontSize = 30
                        }
                    }
                }
            };


        }
    }
}