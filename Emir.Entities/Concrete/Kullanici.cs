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
    [Table("Kullanicilar")]
    public class Kullanici : IEntity
    {
        [Key]
        public int KullaniciId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        [Required(ErrorMessage ="Gerekli Alan"),StringLength(30)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Gerekli Alan"), StringLength(30)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Gerekli Alan")]
        [DataType(DataType.EmailAddress), StringLength(30)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gerekli Alan")]
        [DataType(DataType.Password), StringLength(30)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Gerekli Alan"), StringLength(30)]
        public string KullaniciAdi { get; set; }


    }
}
