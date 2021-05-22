using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectlufi.ViewModels.UrunVM.AyakkabiVM
{
    public class LoaferViewModel
    {
        public ObservableCollection<ListItem> Urunler { get; set; }

        public LoaferViewModel()
        {
            Urunler = new ObservableCollection<ListItem>
            {
                new ListItem {
                    UrunId=111230146100490,
                    UrunAd="Toledo Sneaker Vizon",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=833.33M,
                    UrunFoto="https://cdn.lufian.com/toledo-sneaker-vizon-sneaker-lufian-224906-29-B.jpg" },
                    new ListItem {
                        UrunId=111230146100491,
                    UrunAd="Smıth Deri Loafer Ayakkabı Kırmızı",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/smith-deri-loafer-ayakkabi-kirmizi-loafer-lufian-213688-25-B.jpg" },
                    new ListItem {
                        UrunId=111230146100492,
                    UrunAd="Erie Makosen Ayakkabı Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/gome-deri-loafer-ayakkabi-siyah-loafer-lufian-213705-34-B.jpg" },
                    new ListItem {
                        UrunId=111230146100493,
                    UrunAd="Vanem Deri Loafer Ayakkabı Lacivert",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/vanem-deri-loafer-ayakkabi-lacivert-loafer-lufian-213656-25-B.jpg" },
                    new ListItem {
                        UrunId=111230146100494,
                    UrunAd="Stroll Süet Loafer Ayakkabı Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/erie-makosen-ayakkabi-siyah-klasik-lufian-0-213662-25-B.jpg" },
                    new ListItem {
                        UrunId=111230146100495,
                    UrunAd="Fast Deri Loafer Ayakkabı Siyah",
                    UrunFiyat=199.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/fast-deri-loafer-ayakkabi-siyah-loafer-lufian-225023-71-B.jpg" },
                    new ListItem {
                        UrunId=111230146100496,
                    UrunAd="Gain Mont Kahverengi",
                    UrunFiyat=249.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/fast-deri-loafer-ayakkabi-kahverengi-loafer-lufian-225000-71-B.jpg" },
                    new ListItem {
                        UrunId=111230146100497,
                    UrunAd="Gain Mont Kahverengi",
                    UrunFiyat=559.99M,
                    UrunIndFiyat=749.99M,
                    UrunFoto="https://cdn.lufian.com/stroll-suet-loafer-ayakkabi-kahverengi-loafer-lufian-225041-72-B.jpg" },

            };

        }
    }
}
