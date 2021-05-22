using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.UstGiyimVM
{
    public class CeketViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public CeketViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                      UrunId=1121400991001007,
                    UrunAd="Alfredo Spor Blazer Ceket Lacivert",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/alfredo-spor-blazer-ceket-slim-fit-lacivert-ceket-lufian-224006-41-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001006,
                    UrunAd="Costa Spor Blazer Ceket Kahverengi",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/costa-spor-blazer-ceket-slim-fit-kahverengi-ceket-lufian-224000-41-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001005,
                    UrunAd="Times Spor Blazer Ceket Bej",
                    UrunFiyat=300.00M,
                    UrunIndFiyat=999.99M,
                    UrunFoto="https://cdn.lufian.com/maune-spor-blazer-ceket-slim-fit-bej-ceket-lufian-224011-41-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001004,
                    UrunAd="Ruva Spor Blazer Ceket Siyah",
                    UrunFiyat=390.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/rolf-spor-blazer-ceket-slim-fit-siyah-ceket-lufian-228311-41-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001003,
                    UrunAd="Miana Spor Blazer Ceket Gri",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/times-spor-blazer-ceket-slim-fit-gri-ceket-lufian-210755-38-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001002,
                    UrunAd="Molea Spor Blazer Ceket Vizon",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/ruva-spor-blazer-ceket-slim-fit-vizon-ceket-lufian-210729-38-B.jpg" },
                    new ListItem {
                          UrunId=1121400991001001,
                    UrunAd="Dian Spor Blazer Ceket Lacivert",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/lommel-spor-blazer-ceket-slim-fit-deve-tuyu-ceket-lufian-210746-37-B.jpg" },
                    new ListItem {
                        UrunId=112140099100100,
                    UrunAd="Plica Spor Blazer Ceket Gri",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/miana-spor-blazer-ceket-slim-fit-gri-ceket-lufian-210710-37-B.jpg" },

            };
        }
    }
}
