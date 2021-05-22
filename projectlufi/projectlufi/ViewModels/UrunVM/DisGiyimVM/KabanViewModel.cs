using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.DisGiyimVM
{
    public class KabanViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public KabanViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=112120068100200,
                    UrunAd="Jean Kaz Tüyü Mont Lacivert",
                    UrunFiyat=750.00M,
                    UrunIndFiyat=2499.99M,
                    UrunFoto="https://cdn.lufian.com/tommy-kaz-tuyu-mont-lacivert-mont-lufian-227953-36-B.jpg" },
                    new ListItem {
                        UrunId=112120068100201,
                    UrunAd="Jerome Kaz Tüyü Mont Lacivert",
                    UrunFiyat=720.00M,
                    UrunIndFiyat=2399.99M,
                    UrunFoto="https://cdn.lufian.com/jean-kaz-tuyu-mont-lacivert-mont-lufian-228071-38-B.jpg" },
                    new ListItem {
                        UrunId=112120068100202,
                    UrunAd="Plein Kaz Tüyü Mont Siyah",
                    UrunFiyat=600.00M,
                    UrunIndFiyat=1999.99M,
                    UrunFoto="https://cdn.lufian.com/jerome-kaz-tuyu-mont-siyah-mont-lufian-228053-37-B.jpg" },
                    new ListItem {
                        UrunId=112120068100204,
                    UrunAd="Tommy Kaz Tüyü Mont Beyaz",
                    UrunFiyat=600.00M,
                    UrunIndFiyat=1999.99M,
                    UrunFoto="https://cdn.lufian.com/plein-kaz-tuyu-mont-beyaz-mont-lufian-228047-37-B.jpg" },
                    new ListItem {
                        UrunId=112120068100206,
                    UrunAd="Bogard Kaz Tüyü Mont Taş",
                    UrunFiyat=600.00M,
                    UrunIndFiyat=1999.99M,
                    UrunFoto="https://cdn.lufian.com/bogard-kaz-tuyu-mont-tas-mont-lufian-227900-36-B.jpg" },
                    new ListItem {
                        UrunId=112120068100207,
                    UrunAd="Sawıo Kaz Tüyü Mont Lacivert",
                    UrunFiyat=540.00M,
                    UrunIndFiyat=1799.99M,
                    UrunFoto="https://cdn.lufian.com/sawio-kaz-tuyu-mont-lacivert-mont-lufian-227851-12-B.jpg" },



            };
        }
    }
}
