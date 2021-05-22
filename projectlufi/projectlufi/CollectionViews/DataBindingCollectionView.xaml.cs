using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingCollectionView : ContentPage
    {
        public DataBindingCollectionView()
        {
            InitializeComponent();
            var urunler = new List<ListItem>
            {
                new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },
                    new ListItem {

                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg" },

            };

            urunList.ItemsSource = urunler;
        }
    }
}