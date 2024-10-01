using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DersUygulamasi17
{
    public class ModalessPage : ContentPage
    {
        public ModalessPage()
        {
            Title = "ModalessPage Sayafası";

            Button btnGeri = new Button()
            {
                Text = "Geri",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            btnGeri.Clicked += BtnGeri_Clicked;

            Content = new StackLayout
            {
                Children = {
                    btnGeri
                }
            };
        }

        private void BtnGeri_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}