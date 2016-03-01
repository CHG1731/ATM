using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankalicious
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer de naam in van uw nieuwe klant!");
            var userInput = Console.ReadLine();
            Console.WriteLine("Uw nieuwe klant is: " + userInput);

            var nieuweKlant = new Klant { Name = userInput, Beschrijving = "dit is een nieuwe klant" };
            using (var db = new BankContext())
            {
                db.Klanten.Add(nieuweKlant);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
    public class BankContext : DbContext
    {
        public BankContext() : base("MyDbContextConnectionString") { }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Rekening> Rekeningen { get; set; }
    }
    public class Klant
    {
        [Key]
        public int KlantId { get; set; }
        public string Name { get; set; }
        public string Beschrijving { get; set; }
        public virtual List<Rekening> Rekeningen { get; set; }
    }

    public class Rekening
    {
        public int RekeningId { get; set; }
        public string RekeningNaam { get; set; }
        public string Beschrijving { get; set; }
        public double Saldo { get; set; }

        public int KlantId { get; set; }
        public virtual Klant Klanten { get; set; }

    }
}