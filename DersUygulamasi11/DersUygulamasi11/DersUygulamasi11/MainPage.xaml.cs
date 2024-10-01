using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DersUygulamasi11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Slider mys = new Slider();
            mys.VerticalOptions = LayoutOptions.CenterAndExpand;
            mys.Minimum = 0;
            mys.Maximum = 100;

            Label lblMesaj = new Label();
            lblMesaj.HorizontalOptions = LayoutOptions.CenterAndExpand;
            lblMesaj.VerticalOptions = LayoutOptions.CenterAndExpand;
            lblMesaj.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            lblMesaj.BindingContext = mys;
            lblMesaj.SetBinding(Label.TextProperty, "Value");

            Label lblMesaj2 = new Label();
            lblMesaj2.Text = "Merhaba YBS Bölümü";
            lblMesaj2.HorizontalOptions = LayoutOptions.CenterAndExpand;
            lblMesaj2.VerticalOptions = LayoutOptions.CenterAndExpand;
            lblMesaj2.FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label));

            Slider mys2 = new Slider();
            mys2.VerticalOptions = LayoutOptions.CenterAndExpand;
            mys2.Minimum = 0;
            mys2.Maximum = 1;

            lblMesaj2.BindingContext = mys2;
            lblMesaj2.SetBinding(Label.OpacityProperty, "Value");

            Content = new StackLayout
            {
                Children = { lblMesaj, mys, lblMesaj2, mys2 }
            };

        }
    }
}
