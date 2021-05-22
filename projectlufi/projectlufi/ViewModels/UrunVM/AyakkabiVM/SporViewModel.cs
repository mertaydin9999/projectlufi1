using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AyakkabiVM
{
    public class SporViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public SporViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111230088100100,
                    UrunAd="GBevertly Deri Spor Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=699.99M,
                    UrunFoto="https://cdn.lufian.com/viber-deri-spor-siyah-spor-lufian-224890-69-B.jpg" },
                    new ListItem {
                        UrunId=111230088100101,
                    UrunAd="Prunella Deri Spor Haki",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=699.99M,
                    UrunFoto="https://cdn.lufian.com/prunella-deri-spor-haki-spor-lufian-224815-67-B.jpg" },
                    new ListItem {
                        UrunId=111230088100102,
                    UrunAd="Tom Deri Spor Beyaz",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=699.99M,
                    UrunFoto="https://cdn.lufian.com/tom-deri-spor-beyaz-spor-lufian-224888-69-B.jpg" },
                    new ListItem {
                        UrunId=111230088100103,
                    UrunAd="Viber Deri Spor Siyah",
                    UrunFiyat=219.99M,
                    UrunIndFiyat=799.99M,
                    UrunFoto="https://cdn.lufian.com/beverly-deri-spor-siyah-spor-lufian-211529-14-B.jpg" },
                    new ListItem {
                        UrunId=111230088100104,
                    UrunAd="Max S Deri Spor Yeşil",
                    UrunFiyat=149.99M,
                    UrunIndFiyat=799.99M,
                    UrunFoto="https://cdn.lufian.com/max-s-deri-spor-yesil-spor-lufian-213649-25-B.jpg" },
                    new ListItem {
                        UrunId=111230088100105,
                    UrunAd="Viber Deri Spor Açık Gri",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=799.99M,
                    UrunFoto="https://cdn.lufian.com/wave-deri-spor-beyaz-spor-lufian-224865-68-B.jpg" },
                    new ListItem {
                        UrunId=111230088100106,
                    UrunAd="Prunella Deri Spor Lacivert",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=699.99M,
                    UrunFoto="https://cdn.lufian.com/wave-deri-spor-beyaz-spor-lufian-224865-68-B.jpg" },


            };
        }
    }
}
