using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulmasi6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            /*
             * 
             * ax**2 + bx + c = 0
             * Delta = b**2 - 4ac
             * 
             */
            InitializeComponent();
        }

        private void Topla_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);

            int delta = (b * b) - (4 * a * c);
            if (delta == 0)
            {
                decimal x1 = -b / (2 * a);
                lblSonuc.Text =  "Kökler eşit, x1 = x2 = " + Convert.ToString(x1);
            }
            else
            {
                if (delta > 0)
                {
                    lblSonuc.Text = "x1 = ....., x2 = .....";
                }
                else
                {
                    // reel kök yoktur
                    lblSonuc.Text = "Delta sıfırdan küçük!";
                }
            }
        }
    }
}