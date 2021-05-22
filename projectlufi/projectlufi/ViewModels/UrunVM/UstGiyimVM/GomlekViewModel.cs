using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.UstGiyimVM
{
    public class GomlekViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public GomlekViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                     UrunId=1110103341005500,
                    UrunAd="Pitaya Keten Lacivert Gömlek",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-keten-lacivert-comfort-fit-gomlek-gomlek-lufian-221578-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005501,
                    UrunAd="Pitaya Keten Mavi Gömlek",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-keten-mavi-comfort-fit-gomlek-gomlek-lufian-221583-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005506,
                    UrunAd="Pitaya Keten Beyaz Gömlek",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-keten-beyaz-comfort-fit-gomlek-gomlek-lufian-221588-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005502,
                    UrunAd="Pitaya Keten Lila Gömlek",
                    UrunFiyat=224.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-keten-lila-comfort-fit-gomlek-gomlek-lufian-221593-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005503,
                    UrunAd="Lanza Smart Gömlek Siyah",
                    UrunFiyat=139.99M,
                    UrunIndFiyat=139.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-spor-gomlek-comfort-slim-fit-siyah-gomlek-lufian-228235-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005504,
                    UrunAd="Pablo Smart Gömlek Bej",
                    UrunFiyat=139.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-spor-gomlek-comfort-slim-fit-bej-gomlek-lufian-228240-41-B.jpg" },
                    new ListItem {
                         UrunId=1110103341005505,
                    UrunAd="Albın Smart Gömlek  Yeşil",
                    UrunFiyat=169.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-spor-gomlek-comfort-slim-fit-haki-gomlek-lufian-228245-41-B.jpg" },
                    new ListItem {
                        UrunId=1110103341005507,
                    UrunAd="Grand Smart Gömlek  Lacivert",
                    UrunFiyat=149.99M,
                    UrunIndFiyat=374.99M,
                    UrunFoto="https://cdn.lufian.com/pitaya-100-keten-gomlek-comfort-fit-acik-lacivert-gomlek-lufian-228306-41-B.jpg" },

            };
        }
    }
}
