using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace projectlufi.ViewModels.UrunVM.AksesuarVM
{
    public class CorapViewModel
    {
        public Command GetUrunlerCommand { get; }
        public ObservableCollection<ListItem> Urunler { get; set; }
        public CorapViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId= 110260005100740,
                    UrunAd="Ars Çorap Bordo",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=24.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-bordo-3868-corap-lufian-221058-38-B.jpg" },

                    new ListItem {
                         UrunId= 110260005100741,
                    UrunAd="Ars Çorap Haki",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=19.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-haki-3867-corap-lufian-221057-38-B.jpg" },
                    new ListItem {
                    UrunId= 110260005100742,
                    UrunAd="Ars Çorap Deve Tüyü",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=19.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-deve-tuyu-3865-corap-lufian-221055-38-B.jpg" },
                    new ListItem {
                         UrunId= 110260005100743,
                    UrunAd="Ars Çorap Lacivert",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=19.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-lacivert-3863-corap-lufian-221053-38-B.jpg" },
                    new ListItem {
UrunId= 110260005100744,
                    UrunAd="Ars Çorap Koyu Gri",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=19.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-koyu-gri-3862-corap-lufian-221052-38-B.jpg" },
                    new ListItem {
                        UrunId= 110260005100745,
                    UrunAd="Ars Çorap Siyah",
                    UrunFiyat=17.49M,
                    UrunIndFiyat=24.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-siyah-3861-corap-lufian-221050-38-B.jpg" },
                    new ListItem {
                        UrunId= 110260005100746,
                    UrunAd="Koft Çorap Antrasit",
                    UrunFiyat=16.66M,
                    UrunIndFiyat=24.99M,
                    UrunFoto="https://cdn.lufian.com/ars-corap-koyu-gri-3862-corap-lufian-221052-38-B.jpg" },
                    new ListItem {
                        UrunId= 11026000510077,
                    UrunAd="Amar Babet Çorap Turuncu",
                    UrunFiyat=13.33M,
                    UrunIndFiyat=19.99M,
                    UrunFoto="https://cdn.lufian.com/koft-corap-antrasit-3860-corap-lufian-221047-38-B.jpg" },

            };
        }


    }
}
