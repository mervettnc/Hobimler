using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobimler.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string OgrenciAd { get; set; }
        public virtual ICollection<Hobi> Hobiler { get; set; }
    }
}
