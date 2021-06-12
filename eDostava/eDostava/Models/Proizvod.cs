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
        [DisplayName("Redni broj:")]
        
        public int ID { get; set; }

        [DisplayName("Naziv proizvoda")]
        [Required]
        [RegularExpression(@"[A-Z|a-z| ]*")]
        public string Naziv { get; set; }
        [Range(0.5, 15.0, ErrorMessage ="ECTS bodovi moraju biti u opsegu od 0.5 do 15.0")]
        public double ECTS { get; set; }

        public Proizvod() { }
        public Proizvod(int id, string ime, double ects)
        {
            ID = id;
            Naziv = ime;
            ECTS = ects;
        }

        [NotMapped]
        public List<string> UpisaniStudenti { get; set; }
    }
}
