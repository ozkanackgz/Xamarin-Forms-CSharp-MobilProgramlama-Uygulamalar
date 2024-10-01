using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersUygulamasi8
{
    [DataContract]
    class ResimListesi
    {
        [DataMember(Name = "photos")]

        public List<string> Resimler { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        WebRequest req;
        int gosterimIndis = 0;
        ResimListesi listem;
        public Page2()
        {
            InitializeComponent();
            req = WebRequest.Create("http://192.168.4.42/resimler.json");
            req.BeginGetResponse(DosyaListesiGeldi, null);
        }

        private void DosyaListesiGeldi(IAsyncResult ar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    var resultStream = req.EndGetResponse(ar).GetResponseStream();
                    var jsonSerializer = new DataContractJsonSerializer(typeof(ResimListesi));
                    listem = (ResimListesi)jsonSerializer.ReadObject(resultStream);

                    Uri u = new Uri(listem.Resimler[gosterimIndis]);
                    ImageSource s = ImageSource.FromUri(u);
                    imgBox.Source = s;

                }
                catch (Exception ex)
                {
                    DisplayAlert("Hata", ex.Message, "Tamam");
                }
                    


            });
        }

        private void btnNextImage_Clicked(object sender, EventArgs e)
        {
            gosterimIndis++;

            if (gosterimIndis == 0)
                btnPrevImage.IsEnabled = false;
            else
                btnPrevImage.IsEnabled = true;

            if (gosterimIndis == listem.Resimler.Count-1)
                btnNextImage.IsEnabled = false;
            else
                btnNextImage.IsEnabled = true;

            Uri u = new Uri(listem.Resimler[gosterimIndis]);
            ImageSource s = ImageSource.FromUri(u);
            imgBox.Source = s;
            lblFileName.Text = listem.Resimler[gosterimIndis];
        }

        private void btnPrevImage_Clicked(Object sender, EventArgs e)
        {
            gosterimIndis--;

            if (gosterimIndis == 0)
                btnPrevImage.IsEnabled = false;
            else
                btnPrevImage.IsEnabled = true;

            if (gosterimIndis == listem.Resimler.Count - 1)
                btnNextImage.IsEnabled = false;
            else
                btnNextImage.IsEnabled = true;

            Uri u = new Uri(listem.Resimler[gosterimIndis]);
            ImageSource s = ImageSource.FromUri(u);
            imgBox.Source = s;
            lblFileName.Text = listem.Resimler[gosterimIndis];

        }
    }
}