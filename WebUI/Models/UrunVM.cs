using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class UrunVM
    {
        public int UrunId { get; set; }

        [Required(ErrorMessage = "Gerekli alan"), StringLength(40)]
        public string UrunAdi { get; set; }
        [Required(ErrorMessage = "Gerekli alan"), StringLength(40)]
        public string UrunAciklama { get; set; }
        [Required(ErrorMessage = "Gerekli alan")]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Gerekli alan")]
        public short Stok { get; set; }
        public int KategoriId { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}