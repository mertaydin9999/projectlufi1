using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AltGiyimVM
{
    public class PantolonViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public PantolonViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId= 111190110100600,
                    UrunAd="Marp Spor Pantolon İndigo",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/rain-smart-jean-pantolon-regular-fit-koyu-indigo-denim-lufian-221024-40-B.jpg" },
                    new ListItem {
                        UrunId= 111190110100601,
                    UrunAd="Marcus Spor Pantolon Siyah",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/aden-smart-chino-pantolon-slim-fit-siyah-chino-pantolon-lufian-224421-41-B.jpg" },
                    new ListItem {
                        UrunId= 111190110100602,
                    UrunAd="Marp Spor Pantolon Yeşil",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/marp-spor-5-cep-pantolon-slim-fit-yesil-chino-pantolon-lufian-224465-39-B.jpg" },
                    new ListItem {
                        UrunId= 111190110100603,
                    UrunAd="Marp Spor Pantolon Beyaz",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/marcus-spor-5-cep-pantolon-slim-fit-beyaz-denim-lufian-224448-41-B.jpg" },
                    new ListItem {
                        UrunId= 111190110100604,
                    UrunAd="Marp Spor Pantolon Bej",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/marp-spor-5-cep-pantolon-slim-fit-bej-chino-pantolon-lufian-224461-39-B.jpg" },
                    new ListItem {
                    UrunId= 111190110100605,
                    UrunAd="Raın Smart Jean Pantolon İndigo",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/marp-spor-5-cep-pantolon-slim-fit-gri-chino-pantolon-lufian-224453-40-B.jpg" },
                    new ListItem {
                    UrunId= 111190110100606,
                    UrunAd="Aden Smart Chino Pantolon Siyah",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=499.99M,
                    UrunFoto="https://cdn.lufian.com/marp-spor-5-cep-pantolon-slim-fit-lacivert-chino-pantolon-lufian-224457-40-B.jpg" },
                    new ListItem {
                        UrunId= 111190110100607,
                    UrunAd="Mate Spor Chino Pantolon Mavi",
                    UrunFiyat=287.49M,
                    UrunIndFiyat=574.99M,
                    UrunFoto="https://cdn.lufian.com/descar-smart-jean-pantolon-slim-fit-mavi-denim-lufian-224616-39-B.jpg" },

            };
        }
    }
}
