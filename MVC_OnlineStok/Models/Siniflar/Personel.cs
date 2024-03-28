using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_OnlineStok.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int PersonelID {  get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(30)]

        public string PersonelAd { get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string PersonelSoyad { get; set; }

        public ICollection<KullanimHareketi> KullanimHarekets { get; set; }

        public int DepartmanID { get; set; }
        public virtual Departman Departman { get; set; }

    }
}