using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AksesuarVM
{
    public class KemerViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }

        public KemerViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=220260005100740,
                    UrunAd="Heather Kemer Taş",
                    UrunFiyat=75.99M,
                    UrunIndFiyat=149.99M,
                    UrunFoto="https://cdn.lufian.com/velvet-kemer-tas-kemer-lufian-212767-23-B.jpg" },
                    new ListItem {
                         UrunId=220260005100748,
                    UrunAd="Way Kemer Chesnut",
                    UrunFiyat=149.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/vertical-kemer-chestnut-kemer-lufian-212753-23-B.jpg" },
                    new ListItem {
                         UrunId=220260005100741,
                    UrunAd="Velvet Kemer Kahverengi",
                    UrunFiyat=149.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/keen-orgu-kemer-taba-kemer-lufian-225276-80-B.jpg" },
                    new ListItem {
                         UrunId=220260005100742,
                    UrunAd="Vertical Kemer Chesnut",
                    UrunFiyat=74.99M,
                    UrunIndFiyat=149.99M,
                    UrunFoto="https://cdn.lufian.com/keen-orgu-kemer-kahverengi-kemer-lufian-225275-80-B.jpg" },
                    new ListItem {
                         UrunId=220260005100743,
                    UrunAd="Vertical Kemer Siyah",
                    UrunFiyat=74.99M,
                    UrunIndFiyat=149.99M,
                    UrunFoto="https://cdn.lufian.com/keen-orgu-kemer-siyah-kemer-lufian-225273-80-B.jpg" },
                    new ListItem {
                    UrunId=220260005100744,
                    UrunAd="Kenn Örgü Kemer Taba",
                    UrunFiyat=124.99M,
                    UrunIndFiyat=249.99M,
                    UrunFoto="https://cdn.lufian.com/kass-orgu-kemer-taba-kemer-lufian-225272-80-B.jpg" },
                    new ListItem {
                         UrunId=220260005100745,
                    UrunAd="Keen Örgü Kemer Kahverengi",
                    UrunFiyat=124.99M,
                    UrunIndFiyat=249.99M,
                    UrunFoto="https://cdn.lufian.com/kass-orgu-kemer-kahverengi-kemer-lufian-225271-80-B.jpg" },
                    new ListItem {
                         UrunId=220260005100747,
                    UrunAd="Keen Örgü Kemer Siyah",
                    UrunFiyat=124.99M,
                    UrunIndFiyat=249.99M,
                    UrunFoto="https://cdn.lufian.com/keen-orgu-kemer-siyah-kemer-lufian-225273-80-B.jpg" },

            };
        }
    }
}
