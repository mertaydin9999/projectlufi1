using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.DisGiyimVM
{
    public class MontViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public MontViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111120032100101,
                    UrunAd="Gain Mont Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/jean-kaz-tuyu-mont-lacivert-mont-lufian-228071-38-B.jpg" },
                    new ListItem {
                        UrunId=111120032100102,
                    UrunAd="Tommy Mont Turuncu",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/tommy-kaz-tuyu-mont-lacivert-mont-lufian-227953-36-B.jpg" },
                    new ListItem {
                        UrunId=111120032100102,
                    UrunAd="Harry Mont Siyah",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/mustera-kaz-tuyu-mont-siyah-mont-lufian-228042-36-B.jpg" },
                    new ListItem {
                        UrunId=111120032100103,
                    UrunAd="Harry Mont Lacivert",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/gain-mont-lacivert-mont-lufian-223820-40-B.jpg" },
                    new ListItem {
                        UrunId=111120032100104,
                    UrunAd="Harry Mont Turuncu",
                    UrunFiyat=519.99M,
                    UrunIndFiyat=1299.99M,
                    UrunFoto="https://cdn.lufian.com/gain-mont-turuncu-mont-lufian-223826-40-B.jpg" },
                    new ListItem {
                        UrunId=111120032100105,
                    UrunAd="Ikarus Mont Siyah",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/harry-mont-siyah-mont-lufian-223768-39-B.jpg" },
                    new ListItem {
                        UrunId=111120032100106,
                    UrunAd="Ikarus Mont Saks",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/harry-mont-saks-mont-lufian-223775-39-B.jpg" },
                    new ListItem {
                    UrunId=111120032100107,
                    UrunAd="Albert Mont Kırmızı",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1499.99M,
                    UrunFoto="https://cdn.lufian.com/harry-mont-kirmizi-mont-lufian-223782-39-B.jpg" },

            };
        }
    }
}
