using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.DisGiyimVM
{
    public class PaltoViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public PaltoViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=112120104100100,
                    UrunAd="Jerome Kaz Tüyü Mont Siyah",
                    UrunFiyat=720.00M,
                    UrunIndFiyat=2399.99M,
                    UrunFoto="https://cdn.lufian.com/jerome-kaz-tuyu-mont-siyah-mont-lufian-228053-37-B.jpg" },
                    new ListItem {
                         UrunId=112120104100101,
                    UrunAd="Tavolara Palto Lacivert",
                    UrunFiyat=540.00M,
                    UrunIndFiyat=1799.99M,
                    UrunFoto="https://cdn.lufian.com/zwett-palto-lacivert-palto-lufian-210786-13-B.jpg" },
                    new ListItem {
                         UrunId=112120104100102,
                    UrunAd="Valtaire palto Bej",
                    UrunFiyat=540.00M,
                    UrunIndFiyat=1799.99M,
                    UrunFoto="https://cdn.lufian.com/vence-palto-bej-palto-lufian-210785-13-B.jpg" },
                    new ListItem {
                         UrunId=112120104100103,
                    UrunAd="Palermo Palto Bej",
                    UrunFiyat=540.00M,
                    UrunIndFiyat=1799.99M,
                    UrunFoto="https://cdn.lufian.com/tavolara-palto-bej-palto-lufian-210780-13-B.jpg" },
                    new ListItem {
                         UrunId=112120104100104,
                    UrunAd="Wendy Mont Lacivert",
                    UrunFiyat=600.00M,
                    UrunIndFiyat=1499.99M,
                    UrunFoto="https://cdn.lufian.com/tavolara-palto-lacivert-palto-lufian-210774-13-B.jpg" },



            };
        }
    }
}
