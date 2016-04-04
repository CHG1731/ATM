using Final_Apllication;
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
            Application.Run(new BootScreen());
        }
    }
}
public class Start
{
    public void run()
    {
        Beginscherm begin = new Beginscherm();
        begin.Show();
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

public class HTTPget
{
    public Klant getKlant(string s)
    {
        Klant result = GetKlantData(s).Result;
        return result;

    }
    public String getKlantID(string s)
    {
        String location = String.Concat("/api/pass/", s);
        return getKlantIDthroughRFID(location).Result;
    }
    public Rekening getRekening(string s)
    {
        Rekening result = getRekeningData(s).Result;
        return result;
    }
    static async Task<String> getKlantIDthroughRFID(String s)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:50752/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //GET THE KLANT ID
            HttpResponseMessage response = await client.GetAsync(s).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Pas tmppas = await response.Content.ReadAsAsync<Pas>();
                String result = tmppas.KlantID.ToString();
                return result;
            }
            else
            {
                String result = "0000";
                return result;
            }
        }
    }
    static async Task<Klant> GetKlantData(String s)
    {
        String location = s;
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:50752/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // HTTP GET
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Klant klant = await response.Content.ReadAsAsync<Klant>();
                return klant;
            }
            else
            {
                Klant a = new Klant();
                return a;
                //CONNECTION FAILED
                //RETRY CLAUSE? or cut the program?
            }
        }
    }
    static async Task<Rekening> getRekeningData(string s)
    {
        String location = s;
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:50752/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // HTTP GET
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Rekening rekening = await response.Content.ReadAsAsync<Rekening>();
                return rekening;
            }
            else
            {
                Rekening reject = new Rekening();
                return reject;
            }

        }
    }
}
public class HTTPpost
{
    public void UpdateBalans(int RekeningID, int balans)
    {
        NieuwBalans(RekeningID, balans).Wait();
    }
    static async Task NieuwBalans(int RekeningID, int balans)
    {
        String RekeningIDstring = RekeningID.ToString();
        String location = string.Concat("api/rekenings/", RekeningIDstring);
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:50752/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HTTPpost part
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
               // var tmpJSON = { balans = 10 };
                //await client.PostAsJsonAsync
            }
        }
    }
}

public class Klant
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
public class Pas
{
    public String PasID { get; set; }
    public int RekeningID { get; set; }
    public int KlantID { get; set; }
    public int Actief { get; set; }
    public int Pincode { get; set; }
}
public class Rekening
{
    public int RekeningID { get; set; }
    public int Balans { get; set; }
    public int RekeningType { get; set; }
}
public class Transactie
{
    public int TransactieID { get; set; }
    public int RekeningID { get; set; }
    public int Balans { get; set; }
    public int PasID { get; set; }
}
public class ArduinoData
{
    SerialPort startPort = ArduinoClass.getPort();
    private String inputString;

    public String getString()
    {
        inputString = startPort.ReadTo("\r\n");
        startPort.DiscardInBuffer();
        return inputString;
    }

    public string getPin()
    {
        String pin = "0000";
        return pin;
    }

    public int getChoice()
    {
        int choice = 0;
        string choiceString = this.getString();
        if (choiceString == "AKEY") { choice = 1; }
        if (choiceString == "BKEY") { choice = 2; }
        if (choiceString == "CKEY") { choice = 3; }
        if (choiceString == "$KEY") { choice = 4; }
        return choice;
    }

    public int getUser()
    {
        int userID = 0;
        return userID;
    }
}

public class Executer
{
    private String pincode;
    private int userId;

    public Executer(String p, int u)
    {
        this.pincode = p;
        this.userId = u;
    }

    public void executeChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                pin();
                break;
            case 2:
                checkSaldo();
                break;
            case 3:
                quickPin();
                break;
            case 4:
                break;
        }
    }

    private void pin()
    {
        Pinscherm pinsherm = new Pinscherm();
        pinsherm.Show();
    }

    private void checkSaldo()
    {

    }

    private void quickPin()
    {

    }
}
