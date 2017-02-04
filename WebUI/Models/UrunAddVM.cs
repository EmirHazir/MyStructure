using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class UrunAddVM
    {
        public List<Kategori> Kategoriler { get; internal set; }
        public Urun Urun { get; set; }
    }
}