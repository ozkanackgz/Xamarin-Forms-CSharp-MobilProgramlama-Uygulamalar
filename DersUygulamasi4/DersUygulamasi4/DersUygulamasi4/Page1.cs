using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi4
{
    public class Page1 : ContentPage
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

        public Page1()
        {
            FormattedString formattedString = new FormattedString();
            foreach (var item in boyutlar)
            {
                Span sp1 = new Span();
                sp1.FontSize = Device.GetNamedSize(item, typeof(Label));
                sp1.Text = item.ToString() + " (" + sp1.FontSize + ")" + Environment.NewLine;
                switch (item)
                {
                    case NamedSize.Micro:
                        sp1.TextColor = Color.Red;
                        break;
                    case NamedSize.Small:
                        sp1.TextColor = Color.Blue;
                        break;
                    case NamedSize.Medium:
                        sp1.TextColor = Color.Green;
                        break;
                    case NamedSize.Large:
                        sp1.TextColor = Color.Yellow;
                        break;
                    case NamedSize.Body:
                        sp1.TextColor = Color.Purple;
                        break;
                    case NamedSize.Header:
                        sp1.TextColor = Color.White;
                        break;
                    default:
                        sp1.TextColor =Color.Black;
                        break;
                }
                formattedString.Spans.Add(sp1);
            }
            

            Span sp2 = new Span();
            sp2.Text = "\nBu da ikinci metin içeriğimiz.";
            sp2.FontSize = 20;
            sp2.TextColor = Color.Red;
            formattedString.Spans.Add(sp2);

            Label lbl = new Label();
            lbl.BackgroundColor = Color.BlueViolet;
            lbl.FormattedText = formattedString;
            lbl.HorizontalOptions = LayoutOptions.Center;

            Content = lbl;

        }
    }
}