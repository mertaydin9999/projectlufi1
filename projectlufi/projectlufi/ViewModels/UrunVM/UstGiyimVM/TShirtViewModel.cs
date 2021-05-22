using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.UstGiyimVM
{
    public class TShirtViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public TShirtViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                     UrunId=111020084100100,
                    UrunAd="Laon Spor Polo T-Shirt Açık Lacivert",
                    UrunFiyat=99.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/laon-spor-polo-t-shirt-acik-lacivert-t-shirt-lufian-222666-29-B.jpg" },
                    new ListItem {
                         UrunId=111020084100101,
                    UrunAd="Laon Spor Polo T-Shirt Aqua",
                    UrunFiyat=99.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/laon-spor-polo-t-shirt-aqua-t-shirt-lufian-222682-30-B.jpg" },
                    new ListItem {
                         UrunId=1110200841001002,
                    UrunAd="Laon Spor Polo T-Shirt Siyah",
                    UrunFiyat=99.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/laon-spor-polo-t-shirt-siyah-t-shirt-lufian-222638-29-B.jpg" },
                    new ListItem {
                         UrunId=1110200841001003,
                    UrunAd="Colors Modern Grafik T-Shirt Siyah",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/asen-modern-grafik-t-shirt-siyah-t-shirt-lufian-228261-41-B.jpg" },
                    new ListItem {
                         UrunId=1110200841001004,
                    UrunAd="Colors Modern Grafik T-Shirt Beyaz",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/asen-modern-grafik-t-shirt-kirik-beyaz-t-shirt-lufian-228265-41-B.jpg" },
                    new ListItem {
                         UrunId=1110200841001005,
                    UrunAd="Colors Modern Grafik T-Shirt Siyah",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/colors-modern-grafik-t-shirt-siyah-t-shirt-lufian-222140-40-B.jpg" },
                    new ListItem {
                    UrunId=1110200841001006,
                    UrunAd="Alper Modern Grafik T-Shirt Beyaz",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=149.99M,
                    UrunFoto="https://cdn.lufian.com/colors-modern-grafik-t-shirt-beyaz-t-shirt-lufian-222150-40-B.jpg" },
                    new ListItem {
                        UrunId=1110200841001007,
                    UrunAd="Junya Modern Grafik T-Shirt Lacivert",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=149.99M,
                    UrunFoto="https://cdn.lufian.com/colors-modern-grafik-t-shirt-lacivert-t-shirt-lufian-222145-41-B.jpg" },

            };
        }
    }
}
