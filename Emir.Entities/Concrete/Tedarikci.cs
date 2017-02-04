using Emir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emir.Entities.Concrete
{
    [Table("Tedarikciler")]
    public class Tedarikci : IEntity
    {
        [Key]
        public int TedarikciId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Gerekli alan"), StringLength(40)]
        public string TedarikciAdi { get; set; }
        [Required(ErrorMessage = "Gerekli alan"), StringLength(40)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gerekli alan"), StringLength(240)]
        public string Adres { get; set; }

        public virtual List<Urun> Urunler { get; set; }
    }
}