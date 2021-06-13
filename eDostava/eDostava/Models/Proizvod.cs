using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDostava.Models
{
    public class Proizvod
    {
        [DisplayName("Broj proizvoda")]
        
        public int ID { get; set; }

        [DisplayName("Naziv proizvoda")]
        [Required]
        [RegularExpression(@"[A-Z|a-z| ]*")]
        public string Naziv { get; set; }
        [Range(0.5, 15.0, ErrorMessage ="Kolicina mora biti u opsegu od 0 do 100!")]

        [DisplayName("Količina")]
        public double Kolicina { get; set; }

        public Proizvod() { }
        public Proizvod(int id, string ime, double kolicina)
        {
            ID = id;
            Naziv = ime;
            Kolicina = kolicina;
        }

        [NotMapped]
        public List<string> UpisaniStudenti { get; set; }
    }
}
