using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AyakkabiVM
{
    public class CasualViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public CasualViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                     UrunId=112230161100580,
                    UrunAd="Attıvo Deri Casual Ayakkabı Siyah",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/attivo-deri-casual-ayakkabi-siyah-sneaker-lufian-225101-40-B.jpg" },
                    new ListItem {
                         UrunId=112230161100581,
                    UrunAd="Luminosa Deri Casual Ayakkabı Kahverengi",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/luminosa-deri-casual-ayakkabi-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211664-39-B.jpg" },
                    new ListItem {
                         UrunId=112230161100582,
                    UrunAd="Luminosa Deri Casual Ayakkabı Siyah",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/luminosa-deri-casual-ayakkabi-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211658-38-B.jpg" },
                    new ListItem {
                         UrunId=112230161100583,
                    UrunAd="Vento Deri Casual Ayakkabı Kahverengi",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/vento-deri-casual-ayakkabi-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211646-39-B.jpg" },
                    new ListItem {
                         UrunId=112230161100584,
                    UrunAd="Suıt Deri Casual Ayakkabı Siyah",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/suit-deri-casual-ayakkabi-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211574-38-B.jpg" },
                    new ListItem {
                         UrunId=112230161100585,
                    UrunAd="Vento Deri Casual Ayakkabı Lacivert",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/vento-deri-casual-ayakkabi-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211640-38-B.jpg" },
                    new ListItem {
                         UrunId=112230161100586,
                    UrunAd="Wınd Süet Casual Ayakkabı Kahverengi",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/wind-suet-casual-ayakkabi-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211604-38-B.jpg" },
                    new ListItem {
                        UrunId=112230161100587,
                    UrunAd="Wınd Süet Casual Ayakkabı Kum",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=1399.99M,
                    UrunFoto="https://cdn.lufian.com/wind-suet-casual-ayakkabi-kum-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-casual-lufian-211610-38-B.jpg" },

            };
        }
    }
}
