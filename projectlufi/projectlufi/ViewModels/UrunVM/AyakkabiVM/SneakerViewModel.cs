using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AyakkabiVM
{
    public class SneakerViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public SneakerViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111230101100100,
                    UrunAd="John Deri Casual Ayakkabı Siyah",
                    UrunFiyat=279.99M,
                    UrunIndFiyat=933.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-casual-ayakkabi-siyah-sneaker-lufian-225083-39-B.jpg" },
                    new ListItem {
                        UrunId=111230101100101,
                    UrunAd="John Deri Spor Lacivert",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=833.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-spor-lacivert-sneaker-lufian-225113-40-B.jpg" },
                    new ListItem {
                        UrunId=111230101100102,
                    UrunAd="John Deri Casual Ayakkabı Siyah",
                    UrunFiyat=299.99M,
                    UrunIndFiyat=999.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-casual-ayakkabi-siyah-4102-sneaker-lufian-225095-41-B.jpg" },
                    new ListItem {
                        UrunId=111230101100103,
                    UrunAd="John Deri Spor Gri",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=833.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-spor-gri-sneaker-lufian-225107-41-B.jpg" },
                    new ListItem {
                        UrunId=111230101100104,
                    UrunAd="John Deri Spor Açık Mavi",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=833.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-spor-acik-mavi-sneaker-lufian-225119-41-B.jpg" },
                    new ListItem {
                        UrunId=111230101100105,
                    UrunAd="John Deri Casual Ayakkabı Beyaz",
                    UrunFiyat=279.99M,
                    UrunIndFiyat=933.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-casual-ayakkabi-beyaz-sneaker-lufian-225089-39-B.jpg" },
                    new ListItem {
                        UrunId=111230101100106,
                    UrunAd="Attıvo Deri Casual Ayakkabı Taş",
                    UrunFiyat=279.99M,
                    UrunIndFiyat=933.99M,
                    UrunFoto="https://cdn.lufian.com/john-deri-spor-tas-sneaker-lufian-228281-41-B.jpg" },
                    new ListItem {
                        UrunId=111230101100107,
                    UrunAd="Tommy Deri Sneaker Beyaz",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=833.99M,
                    UrunFoto="https://cdn.lufian.com/perfetto-deri-casual-ayakkabi-beyaz-sneaker-lufian-228229-41-B.jpg" },

            };
        }
    }
}
