using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AltGiyimVM
{
    public class DenizSortuViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public DenizSortuViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111220018100901,
                    UrunAd="Sweet Deniz Şortu Lacivert",
                    UrunFiyat=92.99M,
                    UrunIndFiyat=229.99M,
                    UrunFoto="https://cdn.lufian.com/happy-deniz-sortu-lacivert-deniz-sortu-lufian-224756-66-B.jpg" },
                    new ListItem {
                        UrunId=111220018100902,
                    UrunAd="Sweet Deniz Şortu Saks",
                    UrunFiyat=92.99M,
                    UrunIndFiyat=229.99M,
                    UrunFoto="https://cdn.lufian.com/sweet-deniz-sortu-saks-deniz-sortu-lufian-224768-66-B.jpg" },
                    new ListItem {
                        UrunId=111220018100903,
                    UrunAd="Sweet Deniz Şortu Mavi",
                    UrunFiyat=92.99M,
                    UrunIndFiyat=229.99M,
                    UrunFoto="https://cdn.lufian.com/uno-esofman-alti-gri-esofman-lufian-223171-40-B.jpg" },
                    new ListItem {
                        UrunId=111220018100904,
                    UrunAd="Sweet Deniz Şortu Haki",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=229.99M,
                    UrunFoto="https://cdn.lufian.com/sweet-deniz-sortu-haki-deniz-sortu-lufian-224780-66-B.jpg" },
                    new ListItem {
                        UrunId=111220018100905,
                    UrunAd="Lotus Deniz Şortu Şortu Yeşil",
                    UrunFiyat=80.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/lotus-deniz-sortu-yesil-deniz-sortu-lufian-224783-66-B.jpg" },
                    new ListItem {

                         UrunId=111220018100906,
                    UrunAd="Lotus Deniz Şortu Şortu Kırmızı",
                    UrunFiyat=80.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/lotus-deniz-sortu-kirmizi-deniz-sortu-lufian-224785-67-B.jpg" },
                    new ListItem {
                         UrunId=111220018100907,
                    UrunAd="Lotus Deniz Şortu Şortu Pembe",
                    UrunFiyat=80.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/lotus-deniz-sortu-pembe-deniz-sortu-lufian-224787-67-B.jpg" },
                    new ListItem {
                         UrunId=111220018100908,
                    UrunAd="Lotus Deniz Şortu Şortu Sarı",
                    UrunFiyat=80.99M,
                    UrunIndFiyat=199.99M,
                    UrunFoto="https://cdn.lufian.com/lotus-deniz-sortu-sari-deniz-sortu-lufian-224789-67-B.jpg" },

            };
        }
    }
}
