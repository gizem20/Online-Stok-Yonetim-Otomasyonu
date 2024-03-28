using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVC_OnlineStok.Models.Siniflar
{
    public class KullanimHareketi
        
    {
        [Key]
        public int KullanimID {  get; set; }
        public int Miktar {  get; set; }
        public DateTime Tarih {  get; set; }
        
        public int TeslimNo {  get; set; }
        public string TeslimAlan {  get; set; }


        public int Urunid {  get; set; }
        public int Personelid { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual Personel Personel { get; set; }
        


    }
    
}
