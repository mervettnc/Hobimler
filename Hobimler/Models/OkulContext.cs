using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobimler.Models
{
   public class OkulContext:DbContext
    {
        public OkulContext(): base("name=baglanti")
        {
                
        }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Hobi> Hobiler { get; set; }

    }
}
