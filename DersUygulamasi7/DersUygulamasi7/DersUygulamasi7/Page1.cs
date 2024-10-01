using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi7
{
    public class Page1 : ContentPage
    {
        
        public Page1()
        {
            StackLayout stc = new StackLayout();
            stc.Orientation = StackOrientation.Vertical;
            stc.Padding = new Thickness(10, 10, 10, 10);

            Label lbl = new Label();
            lbl.Text = "0";
            stc.Children.Add(lbl);

            Button btn = new Button();
            btn.TabIndex = 1;
            btn.Text = "ARTTIR";
            btn.Clicked += Btn_Clicked;
            stc.Children.Add(btn);

            Button btn2 = new Button();
            btn2.TabIndex = 2;
            btn2.Text = "AZALT";
            btn2.Clicked += Btn_Clicked;
            stc.Children.Add(btn2);

            Content = stc;

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button; //Button btn = (Button)sender;
            StackLayout s = (StackLayout)btn.Parent; // stacklayout
            Label l = s.Children[0] as Label; // label
            if(btn.TabIndex == 1)
            {
                l.Text = Convert.ToString(Convert.ToInt32(l.Text) + 1);
            }
            if(btn.TabIndex == 2)
            {
                l.Text = Convert.ToString(Convert.ToInt32(l.Text) - 1);
            }

            if (Convert.ToInt32(l.Text) > 0)
                l.BackgroundColor = Color.Green;
            else
            if (Convert.ToInt32(l.Text) == 0)
                l.BackgroundColor = Color.Orange;
            else
                l.BackgroundColor = Color.Red;

        }
    }












































































































































}