using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    [Table("Transactie")]
    public class Transactie
    {
        public int TransactieID { get; set; }
        public int RekeningID { get; set; }
        public int Balans { get; set; }
        public String PasID { get; set; }
    }
}