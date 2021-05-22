using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AksesuarVM
{
    public class MendilViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public MendilViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                     UrunId=440260005100740,
                    UrunAd="Jordan Mendil Haki",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/jordan-mendil-haki-mendil-lufian-211674-30-B.jpg" },
                    new ListItem {
                         UrunId=440260005100741,
                    UrunAd="Maja Mendil Haki",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/maja-mendil-haki-mendil-lufian-211682-15-B.jpg" },
                    new ListItem {
                         UrunId=440260005100742,
                    UrunAd="Dulce Mendil Yeşil",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/dulce-mendil-yesil-mendil-lufian-211681-15-B.jpg" },
                    new ListItem {
                         UrunId=440260005100743,
                    UrunAd="Dulce Mendil Lacivert",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/dulce-mendil-lacivert-mendil-lufian-211678-14-B.jpg" },
                    new ListItem {
                         UrunId=440260005100744,
                    UrunAd="Benita Mendil Gri",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/benita-mendil-haki-mendil-lufian-211676-14-B.jpg" },
                    new ListItem {
                         UrunId=440260005100745,
                    UrunAd="Benita Mendil Lacivert",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/sigma-mendil-bej-mendil-lufian-225194-75-B.jpg" },
                    new ListItem {
                         UrunId=440260005100746,
                    UrunAd="Sigma Mendil Antrasit",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/sigma-mendil-lacivert-mendil-lufian-225193-75-B.jpg" },
                    new ListItem {
                         UrunId=440260005100747,
                    UrunAd="Sigma Mendşl Lacivert",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=99.99M,
                    UrunFoto="https://cdn.lufian.com/jensen-mendil-lacivert-mendil-lufian-225192-75-B.jpg" },

            };
        }
    }
}
