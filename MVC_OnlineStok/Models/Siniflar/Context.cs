using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_OnlineStok.Models.Siniflar
{
    public class Context:DbContext

    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<KullanimHareketi> KullanimHareketis { get; set; }



    }
}