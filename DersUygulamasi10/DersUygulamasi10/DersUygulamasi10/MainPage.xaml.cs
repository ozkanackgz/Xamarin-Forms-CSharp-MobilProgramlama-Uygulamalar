using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DersUygulamasi10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(sender == sKirmizi)
            {
                lblKirmizi.Text = "Kırmızı : " + Convert.ToInt32(e.NewValue).ToString();
            }
            else if(sender == sYesil)
            {
                lblYesil.Text = "Yeşil : " + Convert.ToInt32(e.NewValue).ToString();
            }
            else if(sender == sMavi)
            {
                lblMavi.Text = "Mavi : " + Convert.ToInt32(e.NewValue).ToString();
            }
            Int32 k = Convert.ToInt32(sKirmizi.Value);
            Int32 y = Convert.ToInt32(sYesil.Value);
            Int32 m = Convert.ToInt32(sMavi.Value);
            Color myColor = Color.FromRgb(k, y, m);
            bRenkKutusu.Color = myColor;
        }
    }
}
