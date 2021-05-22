using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.UstGiyimVM
{
    public class KazakViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public KazakViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId= 1110900351002407,
                    UrunAd="İnka Kazak Mavi",
                    UrunFiyat=179.99M,
                    UrunIndFiyat=359.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-mavi-kazak-lufian-223536-40-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002406,
                    UrunAd="İnka Kazak Açık Gri",
                    UrunFiyat=179.99M,
                    UrunIndFiyat=359.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-gri-kazak-lufian-223520-39-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002405,
                    UrunAd="İnka Kazak Açık Lacivert",
                    UrunFiyat=179.99M,
                    UrunIndFiyat=359.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-acik-lacivert-kazak-lufian-223524-39-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002404,
                    UrunAd="İnka Kazak Gece Mavisi",
                    UrunFiyat=179.99M,
                    UrunIndFiyat=359.99M,
                    UrunFoto="https://cdn.lufian.com/anar-kazak-gri-kazak-lufian-223553-40-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002403,
                    UrunAd="İnka Kazak Haki",
                    UrunFiyat=179.99M,
                    UrunIndFiyat=359.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-haki-kazak-lufian-223542-39-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002402,
                    UrunAd="Anar Kazak Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/inka-kazak-siyah-kazak-lufian-228298-41-B.jpg" },
                    new ListItem {
                        UrunId= 1110900351002401,
                    UrunAd="Anar Kazak Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/anar-kazak-siyah-kazak-lufian-223547-40-B.jpg" },
                    new ListItem {
                       UrunId= 111090035100240,
                    UrunAd="Anar Kazak Gri",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/anar-kazak-gri-kazak-lufian-223553-40-B.jpg" },

            };
        }
    }
}
