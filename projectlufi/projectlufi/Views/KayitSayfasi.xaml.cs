using Firebase.Auth;
using projectlufi.Models;
using projectlufi.ViewModels.UyeBilgileriVM;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KayitSayfasi : ContentPage
    {
        public string WebAPIkey = "AIzaSyBTh7oHTF4BE63H1lfOuDDA-AxYQsguoxc";
        public KayitSayfasi()
        {
            InitializeComponent();
           
        }
        async void Kaydet(object sender,System.EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(EmailEntry.Text, SifreEditor.Text);
                string gettoken = auth.FirebaseToken;
               
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Uyari", ex.Message, "Tamam");
            }


            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<UyeBilgileri>();

            var item = new UyeBilgileri()
            {
                UyeAd = AdEditor.Text,
                UyeEmail = EmailEntry.Text,
                UyeSifre = SifreEditor.Text,
                UyeSoyad = SoyadEditor.Text
            };

            if (SifreEditor.Text == SifreYenidenEditor.Text) { 
            db.Insert(item);

            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Tebrikler!", "Kayit Isleminiz Tamamlandi", "Tamam", "Iptal");
                if (result)
                    await Navigation.PushAsync(new GirisSayfasi());
            });
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Uyari!", "Sifre ve sifre yeniden ayni olmali", "Tamam", "Iptal");
                    if (result)
                        await Navigation.PushAsync(new KayitSayfasi());
                });
            }
        }
    }
}