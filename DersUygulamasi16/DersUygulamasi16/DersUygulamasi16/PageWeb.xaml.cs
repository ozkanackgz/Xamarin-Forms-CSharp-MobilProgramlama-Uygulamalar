using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulamasi16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageWeb : ContentPage
    {
        public PageWeb()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            mywebView.Source = ((Entry)sender).Text;
        }

        private void Geri_Clicked(object sender, EventArgs e)
        {
            mywebView.GoBack();
        }

        private void Ileri_Clicked(object sender, EventArgs e)
        {
            mywebView.GoForward();
        }
    }
}