using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    [Table("Klant")]
    public class Klant
    {
        [Key]
        public int KlantID { get; set; }
        public string Naam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        //public virtual ICollection<Rekening> Rekeningen { get; set; }
    }
}