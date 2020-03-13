using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobimler.Models
{
    [Table("Hobiler")]
   public class Hobi
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string HobiAd { get; set; }

        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
