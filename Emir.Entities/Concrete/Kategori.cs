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
    [Table("Kategoriler")]
   public class Kategori : IEntity
    {
        [Key]
        public int KategoriId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }


        [Required(ErrorMessage ="Gerekli alan"),StringLength(50)]
        public string Adi { get; set; }
        [Required(ErrorMessage = "Gerekli alan"), StringLength(150)]
        public string Aciklamasi { get; set; }

        public virtual List<Urun> Urunler { get; set; }
    }
}
