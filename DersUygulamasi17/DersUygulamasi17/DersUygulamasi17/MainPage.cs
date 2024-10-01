using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi17
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Ana Sayfa";

            Button btnModelss = new Button()
            {
                Text = "Modelss Sayfası",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnModelss.Clicked += BtnModeless_Clicked;

            Button btnModal = new Button()
            {
                Text = "Modal Sayfası",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnModal.Clicked += BtnModal_Clicked;


            Content = new StackLayout
            {
                Children = {
                    btnModelss, btnModal
                }
            };
        }

        private void BtnModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalPage());
        }

        private void BtnModeless_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ModalessPage());
        }
    }
}