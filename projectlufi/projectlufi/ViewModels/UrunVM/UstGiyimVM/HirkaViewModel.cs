using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.UstGiyimVM
{
    public class HirkaViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public HirkaViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                          UrunId=1121000121002000,
                    UrunAd="Marian Hırka Nefti Yeşil",
                    UrunFiyat=120.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/armadan-hirka-lacivert-hirka-lufian-227505-38-B.jpg" },
                    new ListItem {
                        UrunId= 1121000121002001,
                    UrunAd="Marian Hırka Lacivert",
                    UrunFiyat=120.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/blazon-hirka-lacivert-hirka-lufian-227532-38-B.jpg" },
                      new ListItem {
                        UrunId= 1121000121002001,
                    UrunAd="Marian Hırka Siyah",
                    UrunFiyat=120.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/dynamic-hirka-siyah-hirka-lufian-227518-37-B.jpg" },
                        new ListItem {
                        UrunId= 1121000121002001,
                    UrunAd="Marian Hırka Antrasit",
                    UrunFiyat=120.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/arda-hirka-antrasit-hirka-lufian-227510-37-B.jpg" },

            };
        }
    }
}
