using System;
using System.Collections.Generic;
using System.Text;

namespace projectlufi.Models
{
    public class UyeBilgileri
    {
        public Guid Id { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeEmail { get; set; }
        public string UyeSifre { get; set; }
    }
}
