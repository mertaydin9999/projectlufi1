using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AksesuarVM
{
    public class CuzdanViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }

        public CuzdanViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111240011100400,
                    UrunAd="Cate Kartlık Kahverengi",
                    UrunFiyat=69.99M,
                    UrunIndFiyat=174.99M,
                    UrunFoto="https://cdn.lufian.com/cate-kartlik-kahverengi-cuzdan-lufian-225139-39-B.jpg" },
                    new ListItem {
                        UrunId=111240011100401,
                    UrunAd="Steven Kartlık Kahverengi",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=124.99M,
                    UrunFoto="https://cdn.lufian.com/cate-kartlik-siyah-cuzdan-lufian-225133-39-B.jpg" },
                    new ListItem {
                        UrunId=111240011100402,
                    UrunAd="Jımmy Cuzdan Kahverengi",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/jimmy-cuzdan-kahverengi-cuzdan-lufian-225172-38-B.jpg" },
                    new ListItem {
                        UrunId=111240011100403,
                    UrunAd="Jımmy Cüzdan Siyah",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/jimmy-cuzdan-siyah-cuzdan-lufian-225169-38-B.jpg" },
                    new ListItem {
                        UrunId=111240011100404,
                    UrunAd="Jack Cüzdan Kahverengi",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/jack-cuzdan-kahverengi-cuzdan-lufian-225166-38-B.jpg" },
                    new ListItem {
            UrunId=111240011100405,
                    UrunAd="Jack Cüzdan Siyah",
                    UrunFiyat=79.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/jack-cuzdan-siyah-cuzdan-lufian-225163-38-B.jpg" },
                    new ListItem {
                        UrunId=111240011100406,
                    UrunAd="Taylor Kartlık Kahverengi",
                    UrunFiyat=69.99M,
                    UrunIndFiyat=174.99M,
                    UrunFoto="https://cdn.lufian.com/taylor-kartlik-kahverengi-cuzdan-lufian-225157-38-B.jpg" },
                    new ListItem {
                        UrunId=111240011100407,
                    UrunAd="Taylor Kartlık Siyah",
                    UrunFiyat=69.99M,
                    UrunIndFiyat=174.99M,
                    UrunFoto="https://cdn.lufian.com/jack-cuzdan-siyah-cuzdan-lufian-225163-38-B.jpg" },

            };
        }
    }
}
