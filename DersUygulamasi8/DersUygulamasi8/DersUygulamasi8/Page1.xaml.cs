using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulamasi8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            Uri myuri = new Uri("https://f4n3x6c5.stackpathcdn.com/article/consume-https-service-with-self-signed-certificate-in-xamarin-forms/Images/Consume%20Https%20Service%20With%20Self-Signed%20Certificate%20In%20Xamarin%20Forms.jpg");
            ImageSource imgs = ImageSource.FromUri(myuri);

            ImageSource imgsEmbed = ImageSource.FromResource("DersUygulamasi8.İmages.IMG_5620.jpg");

            img1.Source = imgsEmbed;
        }
    }
}