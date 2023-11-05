using ProjeTakip.Models.Personel;
using ProjeTakip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjeTakip.Models.DataContext
{
    public class ProjeTakipDBContext:DbContext
    {
        public ProjeTakipDBContext() : base("ProjeTakipDB")
        {

        }
        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}
