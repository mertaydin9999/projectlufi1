using projectlufi.Models;
using projectlufi.Views;
using projectlufi.Views.UrunSayfalari.AltGiyim;
using projectlufi.Views.UrunSayfalari.Ayakkabi;
using projectlufi.Views.UrunSayfalari.UstGiyim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        async void UyeGiris(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GirisSayfasi());
        }
        
        async void UyeOl(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KayitSayfasi());
        }
        async void BosSepeteGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BosSepetSayfasi());
        }
        async void KazaklaraGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KazakSayfasi());
        }
        async void EsofmanlaraGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EsofmanSayfasi());
        }
        async void AyakkabilaraGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SporSayfasi());
        }
        async void TshirtlereGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TShirtSayfasi());
        }
        async void UstGiyimeGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HirkaSayfasi());
        }
        async void CeketlereGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CeketSayfasi());
        }
        async void GomleklereGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GomlekSayfasi());
        }
        async void PantolonlaraGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantolonSayfasi());
        }


    }
}