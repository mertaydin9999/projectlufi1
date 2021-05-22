using Firebase.Database;
using Firebase.Database.Query;
using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetSayfasi : ContentPage
    {
        public SepetSayfasi(ListItem urunler)
        {
            InitializeComponent();
            BindingContext = urunler;
            lblCount.Text = 1.ToString();
        }

        async void AnaSayfayaDon(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

         async void SatinAl(object sender, EventArgs e)
        {
           



            var urun = (ListItem)BindingContext;
            urun.Date = DateTime.Now;
            await App.Database.SaveListsAsync(urun);
            await Navigation.PushAsync(new SiparislerSayfasi());

                FirebaseClient fc = new FirebaseClient("https://xffirebaseemailauth-f491a-default-rtdb.firebaseio.com/");
            var result = await fc
            .Child("ListItem")
            .PostAsync(new ListItem(){UrunAd = urun.UrunAd, UrunFiyat = urun.UrunFiyat, UrunFoto = urun.UrunFoto });

        }
        public void Eksilt(object sender , EventArgs e)
        {
           var value = (sender as Button).Text = 1.ToString();
            value = "1";
            lblCount.Text = value;
        }
        public void Arttir(object sender, EventArgs e)
        {
            var value = (sender as Button).Text = 1.ToString();
            value = "2";
            lblCount.Text = value;
            
            
        }



    }
}