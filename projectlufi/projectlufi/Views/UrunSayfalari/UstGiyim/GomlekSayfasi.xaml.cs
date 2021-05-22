using projectlufi.Models;
using projectlufi.ViewModels.UrunVM.UstGiyimVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views.UrunSayfalari.UstGiyim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GomlekSayfasi : ContentPage
    {
        public GomlekSayfasi()
        {
            InitializeComponent();
            BindingContext = new GomlekViewModel();
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