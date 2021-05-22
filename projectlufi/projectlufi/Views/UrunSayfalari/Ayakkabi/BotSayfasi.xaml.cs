using projectlufi.Models;
using projectlufi.ViewModels.UrunVM.AyakkabiVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views.UrunSayfalari.Ayakkabi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BotSayfasi : ContentPage
    {
        public BotSayfasi()
        {
            InitializeComponent();
            BindingContext = new BotViewModel();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var urunler = e.CurrentSelection.FirstOrDefault() as ListItem;
            if (urunler == null)
                return;
            await Navigation.PushAsync(new DetaySayfasi(urunler));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}