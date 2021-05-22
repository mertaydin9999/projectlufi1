using Firebase.Auth;
using Newtonsoft.Json;
using projectlufi.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisSayfasi : ContentPage
    {
        public string WebAPIkey = "AIzaSyBTh7oHTF4BE63H1lfOuDDA-AxYQsguoxc";
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KayitSayfasi());
        }
        async void  GirisYap(object sender, EventArgs e)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
            try 
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(EmailEntry.Text, SifreEntry.Text);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                await Navigation.PushAsync(new GirisSayfasi());
            }
            catch { }




            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<UyeBilgileri>().Where(u => u.UyeEmail.Equals(EmailEntry.Text) && u.UyeSifre.Equals(SifreEntry.Text)).FirstOrDefault();
            if (myquery != null)
            {
                App.Current.MainPage = new AppShell();
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Hata!", "Gecersiz Kullanici", "Tamam", "Iptal");
                    if (result)
                        await Navigation.PushAsync(new GirisSayfasi());
                    else
                    {
                        await Navigation.PushAsync(new GirisSayfasi());
                    }
                });
            }
        }
    }
}