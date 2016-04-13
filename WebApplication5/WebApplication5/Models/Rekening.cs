using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    [Table("Rekening")]
    public class Rekening
    {
        public int RekeningID { get; set; }
        public double Balans { get; set; }
        public int RekeningType { get; set; }
        public String Hash { get; set; }
    }
}