using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AksesuarVM
{
    public class KravatViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public KravatViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                     UrunId=330260005100740,
                    UrunAd="Melan Kravat Bord",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=89.99M,
                    UrunFoto="https://cdn.lufian.com/melan-kravat-bordo-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211870-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100741,
                    UrunAd="Melan Kravat Kahverengi",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=89.99M,
                    UrunFoto="https://cdn.lufian.com/melan-kravat-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211868-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100742,
                    UrunAd="Melan Kravat Lacivert",
                    UrunFiyat=59.99M,
                    UrunIndFiyat=89.99M,
                    UrunFoto="https://cdn.lufian.com/melan-kravat-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211866-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100743,
                    UrunAd="Allen Kravat Saks",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=79.99M,
                    UrunFoto="https://cdn.lufian.com/russell-kravat-yesil-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211850-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100744,
                    UrunAd="Allen Kravat Lacivert",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=79.99M,
                    UrunFoto="https://cdn.lufian.com/allen-kravat-saks-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211854-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100745,
                    UrunAd="Russel Kravat Yeşil",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=79.99M,
                    UrunFoto="https://cdn.lufian.com/allen-kravat-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211852-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100746,
                    UrunAd="Danıel Kravat Yeşil",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=79.99M,
                    UrunFoto="https://cdn.lufian.com/russell-kravat-yesil-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211850-35-B.jpg" },
                    new ListItem {
                         UrunId=220260005100747,
                    UrunAd="Daniel Kravat Lacivert",
                    UrunFiyat=49.99M,
                    UrunIndFiyat=79.99M,
                    UrunFoto="https://cdn.lufian.com/russell-kravat-yesil-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kravat-lufian-211850-35-B.jpg" },

            };
        }
    }
}
