using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AyakkabiVM
{
    public class BotViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public BotViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=772120068100200,
                    UrunAd="Mezzo Süet Casual Ayakkabı Haki",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=624.99M,
                    UrunFoto="https://cdn.lufian.com/mezzo-suet-casual-ayakkabi-haki-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-211634-37-B.jpg" },
                    new ListItem {
                    UrunId=772120068100201,
                    UrunAd="Mezzo Süet Casual Ayakkabı Kahverengi",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=624.99M,
                    UrunFoto="https://cdn.lufian.com/mezzo-suet-casual-ayakkabi-kahverengi-bot-lufian-211628-37-B.jpg" },
                    new ListItem {
                        UrunId=772120068100202,
                    UrunAd="Mezzo Süet Casual Ayakkabı Lacivert",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=624.99M,
                    UrunFoto="https://cdn.lufian.com/mezzo-suet-casual-ayakkabi-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-211622-38-B.jpg" },
                    new ListItem {
                        UrunId=772120068100203,
                    UrunAd="Serrato Deri Bot Siyah",
                    UrunFiyat=299.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/serrato-deri-bot-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-211668-37-B.jpg" },
                    new ListItem {
                        UrunId=772120068100204,
                    UrunAd="Greıge Deri Bot Kahverengi",
                    UrunFiyat=279.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/greige-deri-bot-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-211586-39-B.jpg" },
                    new ListItem {
                        UrunId=772120068100205,
                    UrunAd="Greige Deri Bot Siyah",
                    UrunFiyat=279.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/greige-deri-bot-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-211580-39-B.jpg" },
                    new ListItem {
                        UrunId=772120068100206,
                    UrunAd="Vıncent Deri Bot Bordı",
                    UrunFiyat=229.99M,
                    UrunIndFiyat=899.99M,
                    UrunFoto="https://cdn.lufian.com/vincent-deri-bot-bordo-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-212624-23-B.jpg" },
                    new ListItem {
UrunId=772120068100207,
                    UrunAd="Arnold Deri Bot Kahverengi",
                    UrunFiyat=229.99M,
                    UrunIndFiyat=899.99M,
                    UrunFoto="https://cdn.lufian.com/arnold-deri-bot-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-bot-lufian-212655-23-B.jpg" },

            };
        }
    }
}
