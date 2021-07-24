using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ornekSite.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lüften Adresinizi Giriniz")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lüften Şehir Giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lüften Semt(İlçe) Giriniz")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lüften Mahalle Giriniz")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lüften Posta Kodu Giriniz")]
        public string PostaKodu { get; set; }
    }
}