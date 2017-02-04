using Emir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Entities.Concrete
{
    [Table("Urunler")]
    public class Urun : IEntity
    {
        [Key]
        public int UrunId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        [Required(ErrorMessage ="Gerekli alan"),StringLength(40)]
        public string UrunAdi { get; set; }
        [Required(ErrorMessage = "Gerekli alan"), StringLength(40)]
        public string UrunAciklama { get; set; }
        [Required(ErrorMessage = "Gerekli alan")]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Gerekli alan")]
        public short Stok { get; set; }
        public int KategoriId { get; set; }

        public virtual List<Tedarikci> Tedarikci { get; set; }


    }
}
