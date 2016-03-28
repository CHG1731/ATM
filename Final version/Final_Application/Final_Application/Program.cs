using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Init1());
        }
    }
}
public class ArduinoClass
{
    static SerialPort Arduino = new SerialPort();
    static String portName = "COM1";
    public static bool makePort(String s)
    {
        portName = s;
        bool status = false;
        Arduino.BaudRate = 9600;
        Arduino.PortName = portName;
        try
        {
            Arduino.Open();
            status = true;
        }
        catch (System.IO.IOException)
        {
            Error.show("Poort niet gevonden", "Error");
        }
        catch (System.UnauthorizedAccessException)
        {
            Error.show("Toegang tot de compoort is geweigerd", "Error");
        }
        catch (Exception)
        {
            Error.show("No port selected", "Error");
        }
        return status;
    }
    public static SerialPort getPort()
    {
        return Arduino;
    }
}

public class Error
{
    public static void show(String s, String x)
    {
        MessageBox.Show(s, x,
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

}

public class HTTPClass
{
    public void info()
    {
        RunAsync().Wait();
    }
    static async Task RunAsync()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:50752/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // HTTP GET
            HttpResponseMessage klantresponse = await client.GetAsync("api/Klants/2").ConfigureAwait(false);
            if (klantresponse.IsSuccessStatusCode)
            {
                Klant klant = await klantresponse.Content.ReadAsAsync<Klant>();
                //Console.WriteLine("Naam: {0} Achternaam: {3} Adres: {1} KlantID: {2} Postcode: {4}", klant.Naam, klant.Adres, klant.KlantID, klant.Achternaam, klant.Postcode);
            }
            else
            {
                //CONNECTION FAILED
                //RETRY CLAUSE? or cut the program?
            }
        }
    }

    partial class Klant
    {

        public string Adres { get; set; }
        public int KlantID { get; set; }
        public string Naam { get; set; }
        public string Achternaam { get; set; }
        public String Postcode { get; set; }
        public String getNaam()
        {
            return Naam;
        }
    }
    partial class Pas
    {
        public String PasID { get; set; }
        public int RekeningID { get; set; }
        public int KlantID { get; set; }
        public int Actief { get; set; }
        public int Pincode { get; set; }
    }
    partial class Rekening
    {
        public int RekeningID { get; set; }
        public int Balans { get; set; }
        public int RekeningType { get; set; }
    }
    partial class Transactie
    {
        public int TransactieID { get; set; }
        public int RekeningID { get; set; }
        public int Balans { get; set; }
        public int PasID { get; set; }
    }
}

