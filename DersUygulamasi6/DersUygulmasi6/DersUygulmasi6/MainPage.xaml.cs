using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DersUygulmasi6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            txtSayi1.Text = "0";
            txtSayi2.Text = "0";
        }

        private void Topla_Clicked(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;
            int s3 = Convert.ToInt32(s1) + Convert.ToInt32(s2);
            lblSonuc.Text = s1 + " + " + s2 + " = " + Convert.ToInt32(s3);
        }
    }
}
