using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AltGiyimVM
{
    public class EsofmanViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public EsofmanViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111050015100200,
                    UrunAd="Lennar Eşofman Altı Lacivert",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/water-esofman-alti-lacivert-esofman-lufian-223146-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100201,
                    UrunAd="Lennar Eşofman Altı Beyaz",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/water-esofman-alti-kirik-beyaz-esofman-lufian-223151-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100202,
                    UrunAd="Water Eşofman Altı Yeşil",
                    UrunFiyat=139.99M,
                    UrunIndFiyat=349.99M,
                    UrunFoto="https://cdn.lufian.com/lennar-esofman-alti-yesil-esofman-lufian-223156-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100203,
                    UrunAd="Water Eşofman Altı Turuncu",
                    UrunFiyat=139.99M,
                    UrunIndFiyat=349.99M,
                    UrunFoto="https://cdn.lufian.com/lennar-esofman-alti-turuncu-esofman-lufian-223161-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100204,
                    UrunAd="Water Eşofman Altı Siyah",
                    UrunFiyat=139.99M,
                    UrunIndFiyat=349.99M,
                    UrunFoto="https://cdn.lufian.com/uno-esofman-alti-siyah-esofman-lufian-223166-40-B.jpg" },
                    new ListItem {
                        UrunId=111050015100205,
                    UrunAd="Uno Eşofman Altı Siyah",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=449.99M,
                    UrunFoto="https://cdn.lufian.com/water-esofman-alti-siyah-esofman-lufian-223136-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100206,
                    UrunAd="Uno Eşofman Altı Gri",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/water-esofman-alti-gri-esofman-lufian-223141-41-B.jpg" },
                    new ListItem {
                        UrunId=111050015100207,
                    UrunAd="Uno Eşofman Altı Gri",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/uno-esofman-alti-gri-esofman-lufian-223171-40-B.jpg" },

            };
        }
    }
}
