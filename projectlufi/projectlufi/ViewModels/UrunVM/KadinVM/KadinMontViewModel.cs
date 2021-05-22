using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.KadinVM
{
    public class KadinMontViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }
        public KadinMontViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=122120008100700,
                    UrunAd="Landlor Kaz Tüyü Mont Kahverengi",
                    UrunFiyat=525.00M,
                    UrunIndFiyat=1749.99M,
                    UrunFoto="https://cdn.lufian.com/landlor-kaz-tuyu-mont-kahverengi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-secili-urunlerde-60-indirime-ek-sepette-lufian-211889-38-B.jpg" },
                    new ListItem {
                        UrunId=122120008100701,
                    UrunAd="Lora Kaz Tüyü Mont Siyah",
                    UrunFiyat=675.00M,
                    UrunIndFiyat=2249.99M,
                    UrunFoto="https://cdn.lufian.com/lora-kaz-tuyu-mont-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-211883-38-B.jpg" },
                    new ListItem {
                        UrunId=122120008100702,
                    UrunAd="Flora Kaz Tüyü Mont Siyah",
                    UrunFiyat=675.00M,
                    UrunIndFiyat=2249.99M,
                    UrunFoto="https://cdn.lufian.com/flora-kaz-tuyu-mont-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-211874-36-B.jpg" },
                    new ListItem {
                        UrunId=122120008100703,
                    UrunAd="Fızy Kaz Tüyü Mont Kırmızı",
                    UrunFiyat=450.00M,
                    UrunIndFiyat=1499.99M,
                    UrunFoto="https://cdn.lufian.com/fizy-kaz-tuyu-mont-kirmizi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-0-211897-36-B.jpg" },
                    new ListItem {
                        UrunId=122120008100704,
                    UrunAd="Fızy Kaz Tüyü Mont Siyah",
                    UrunFiyat=450.00M,
                    UrunIndFiyat=1499.99M,
                    UrunFoto="https://cdn.lufian.com/fizy-kaz-tuyu-mont-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-211892-36-B.jpg" },
                    new ListItem {
                        UrunId=122120008100705,
                    UrunAd="Dolly Kaz Tüyü Mont Siyah",
                    UrunFiyat=525.00M,
                    UrunIndFiyat=1749.99M,
                    UrunFoto="https://cdn.lufian.com/dolly-kaz-tuyu-mont-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-211879-36-B.jpg" },
                    new ListItem {
                        UrunId=122120008100706,
                    UrunAd="Elin Kaz Tüyü Mont Kırmızı",
                    UrunFiyat=699.99M,
                    UrunIndFiyat=1749.99M,
                    UrunFoto="https://cdn.lufian.com/elin-kaz-tuyu-mont-kirmizi-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-211912-35-B.jpg" },
                    new ListItem {
                        UrunId=122120008100707,
                    UrunAd="Elin Kaz Tüyü Mont Siyah",
                    UrunFiyat=699.99M,
                    UrunIndFiyat=1749.99M,
                    UrunFoto="https://cdn.lufian.com/elin-kaz-tuyu-mont-siyah-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-0-211907-35-B.jpg" },

            };
        }
    }
}
