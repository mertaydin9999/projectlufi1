using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AltGiyimVM
{
    public class SortViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public SortViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111210038100200,
                    UrunAd="Solid Spor Chino Şort Lacivert",
                    UrunFiyat=160.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/solad-spor-chino-sort-slim-fit-lacivert-sort-lufian-224665-28-B.jpg" },
                    new ListItem {
                        UrunId=111210038100201,
                    UrunAd="Sipso Spor Chino Şort Bej",
                    UrunFiyat=160.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/sipso-spor-chino-sort-slim-fit-bej-chino-pantolon-lufian-224713-65-B.jpg" },
                    new ListItem {
                        UrunId=111210038100202,
                    UrunAd="Cipo Spor Chino Şort Lacivert",
                    UrunFiyat=160.00M,
                    UrunIndFiyat=399.99M,
                    UrunFoto="https://cdn.lufian.com/solid-spor-chino-sort-slim-fit-lacivert-chino-pantolon-lufian-224717-65-B.jpg" },
                    new ListItem {
                        UrunId=111210038100203,
                    UrunAd="Aryan Spor Chino Şort Lacivert",
                    UrunFiyat=132.99M,
                    UrunIndFiyat=329.99M,
                    UrunFoto="https://cdn.lufian.com/cipo-spor-chino-sort-slim-fit-lacivert-chino-pantolon-lufian-224710-65-B.jpg" },
                    new ListItem {
                        UrunId=111210038100204,
                    UrunAd="Aryan Spor Chino Şort Yeşil",
                    UrunFiyat=140.00M,
                    UrunIndFiyat=349.99M,
                    UrunFoto="https://cdn.lufian.com/aryan-spor-chino-sort-slim-fit-yesil-chino-pantolon-lufian-224706-65-B.jpg" },
                    new ListItem {
                        UrunId=111210038100205,
                    UrunAd="Aryan Spor Chino Şort Beyaz",
                    UrunFiyat=148.00M,
                    UrunIndFiyat=369.99M,
                    UrunFoto="https://cdn.lufian.com/aryan-spor-chino-sort-slim-fit-beyaz-chino-pantolon-lufian-224702-64-B.jpg" },
                    new ListItem {
                        UrunId=111210038100206,
                    UrunAd="Aryan Spor Chino Şort Gece Mavisi",
                    UrunFiyat=160.00M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/aryan-spor-chino-sort-slim-fit-mavi-chino-pantolon-lufian-224698-64-B.jpg" },
                    new ListItem {
                        UrunId=111210038100207,
                    UrunAd="Aries Spor Chino Şort Lacivert",
                    UrunFiyat=148.00M,
                    UrunIndFiyat=369.99M,
                    UrunFoto="https://cdn.lufian.com/aryan-spor-chino-sort-slim-fit-gece-mavisi-chino-pantolon-lufian-224694-64-B.jpg" },

            };
        }
    }
}
