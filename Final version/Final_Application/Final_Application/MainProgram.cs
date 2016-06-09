using Final_Apllication;
using System;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using DYMO.Label.Framework;
using System.Collections.Generic;
using System.Net.Mail;


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
    public static void show(String s)
    {
        MessageBox.Show(s, s,
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

public class HTTPget
{
    public bool getActiefStand(String pasID)
    {
        Pas temp = getActiefStandData(pasID).Result;
        if (temp.Actief == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Pas getPinclass(String s)
    {
        Pas tmp = getPinData(s).Result;
        return tmp;
    }
    public int getFalsePinnr(String s)
    {
        Pas tmp = getPinData(s).Result;
        int falsepi = tmp.FalsePin;
        return falsepi;
    }
    public Klant getKlant(string s)
    {
        Klant result = GetKlantData(s).Result;
        return result;

    }
    public String getKlantID(string s)
    {
        String location = String.Concat("/api/pass/", s);
        return getKlantIDthrougPasID(location).Result;
    }
    public Rekening getRekening(string s)
    {
        String loc = String.Concat("api/rekenings/", s);
        Rekening result = getRekeningData(loc).Result;
        return result;
    }
    public String getHash(String RekeningID)
    {
        String loc = String.Concat("/api/rekenings/", RekeningID);
        Rekening result = getRekeningData(loc).Result;
        return result.Hash;
    }
    static async Task<String> getKlantIDthrougPasID(String s)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //GET THE KLANT ID
            HttpResponseMessage response = await client.GetAsync(s).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Pas tmppas = await response.Content.ReadAsAsync<Pas>();
                String result = tmppas.klantID.ToString();
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

        String location = String.Concat("/api/klants/", s);
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
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
                Error.show("FAILED TO GET KLANT");
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
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
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
    static async Task<Pas> getPasData(string s)
    {
        String location = s;
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // HTTP GET
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Pas pas = await response.Content.ReadAsAsync<Pas>();
                return pas;
            }
            else
            {
                Pas reject = new Pas();
                return reject;
            }

        }
    }
    static async Task<Pas> getPinData(string ID)
    {
        String location = string.Concat("api/Pass/", ID);
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // HTTP GET
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Pas FalsePin = await response.Content.ReadAsAsync<Pas>();
                return FalsePin;
            }
            else
            {
                Pas reject = new Pas();
                return reject;
            }

        }
    }
    static async Task<Pas> getActiefStandData(string ID)
    {
        String location = string.Concat("api/Pass/", ID);
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // HTTP GET
            HttpResponseMessage response = await client.GetAsync(location).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Pas Actief = await response.Content.ReadAsAsync<Pas>();
                return Actief;
            }
            else
            {
                Pas reject = new Pas();
                return reject;
            }

        }
    }
}

public class HTTPpost
{
    public void transaction(String PasID, String RekeningID, int Balans)
    {
        Transactie(PasID, RekeningID, Balans).Wait();
    }
    public void resetfalsepin(String PasID)
    {
        HTTPget tmp = new HTTPget();
        Pas resetdata = tmp.getPinclass(PasID);
        incrementFalsePin(PasID, resetdata, 0).Wait();
    }
    public void Incrementfalsepin(String PasID)
    {
        HTTPget tmp = new HTTPget();
        int nrfalsepin = tmp.getFalsePinnr(PasID);
        Pas uploaddata = tmp.getPinclass(PasID);
        nrfalsepin++;
        if (nrfalsepin >= 3)
        {
            BlockScreen a = new BlockScreen();
            BlockCard(PasID, uploaddata).Wait();
        }
        if (nrfalsepin < 3)
        {
            incrementFalsePin(PasID, uploaddata, nrfalsepin).Wait();
        }
    }
    public void UpdateBalans(int RekeningID, int balans)
    {
        NieuwBalans(RekeningID, balans).Wait();
    }
    static async Task Transactie(String PasID, String RekeningID, int balans)
    {
        int RekeningIDint;
        Int32.TryParse(RekeningID, out RekeningIDint);
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HTTPpost part
            var trans = new Transactie() { Balans = balans, PasID = Int32.Parse(PasID), RekeningID = RekeningIDint.ToString(), AtmID = "HRO" };
            HttpResponseMessage response = await client.PostAsJsonAsync("api/transacties", trans).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("TRANSACTIE SUCCEED");
            }
            else
            {
                Error.show("TRANSACTIE FAILED");
            }
        }
    }
    static async Task NieuwBalans(int RekeningID, int balans)
    {
        String location = string.Concat("api/rekenings/", RekeningID.ToString());
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HTTPpost part
            HTTPget tmp = new HTTPget();
            Rekening trans = tmp.getRekening(RekeningID.ToString());
            trans.Balans = balans;
            HttpResponseMessage response = await client.PutAsJsonAsync(location, trans).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("Succeeded", "Succeeded");
            }
            else
            {
                Error.show("NIEW BALANS FAILED");
            }
        }
    }
    static async Task incrementFalsePin(String PasID, Pas data, int falsepinnr)
    {
        String location = string.Concat("api/pass/", PasID.ToString());
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HTTPpost part
            Pas incrementFalsePin = new Pas() { Actief = data.Actief, FalsePin = falsepinnr, klantID = data.klantID, pasID = Int32.Parse(PasID), rekeningID = data.rekeningID };
            HttpResponseMessage response = await client.PutAsJsonAsync(location, incrementFalsePin).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("INCREMENTING SUCCED", "INCREMENT Succeeded");
            }
            else
            {
                Error.show("INCR FAILED", "INCR FAILED");
            }
        }
    }
    static async Task BlockCard(String PasID, Pas data)
    {
        String location = string.Concat("api/pass/", PasID.ToString());
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://hrsqlapp.tk/WebApp/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HTTPpost part
            Pas incrementFalsePin = new Pas() { Actief = 0, FalsePin = data.FalsePin, klantID = data.klantID, pasID = Int32.Parse(PasID), rekeningID = data.rekeningID };
            HttpResponseMessage response = await client.PutAsJsonAsync(location, incrementFalsePin).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("INCREMENTING SUCCED", "INCREMENT Succeeded");
            }
            else
            {
                Error.show("BLOCKING FAILED", "BLOCKING FAILED");
            }
        }
    }
}

public class Klant
{

    public int KlantID { get; set; }
    public string voornaam { get; set; }
    public string achternaam { get; set; }
    public string email { get; set; }
    public String getNaam()
    {
        return voornaam;
    }
}
public class Pas
{
    public int pasID { get; set; }
    public string rekeningID { get; set; }
    public int klantID { get; set; }
    public int Actief { get; set; }
    public int FalsePin { get; set; }
}
public class Rekening
{
    [Key]
    public string RekeningID { get; set; }
    public int Balans { get; set; }
   // public int RekeningType { get; set; }
    public String Hash { get; set; }
}
public class Transactie
{
    [Key]
    public int TransactieID { get; set; }
    public string RekeningID { get; set; }
    public int Balans { get; set; }
    public int PasID { get; set; }
    public String AtmID { get; set; }
}
public class ArduinoData
{
    //SerialPort startPort = ArduinoClass.getPort();
    SerialPort startPort = maakpoorteen();
    static String[] comports = System.IO.Ports.SerialPort.GetPortNames();
    SerialPort dispenserPort = maakpoorttwee();
    private String inputString;

    public String getFirstString()
    {
        inputString = startPort.ReadTo("\r\n");
        return inputString;
    }
    public static SerialPort maakpoorteen()
    {
        SerialPort een = new SerialPort();
        een.BaudRate = 9600;
        een.PortName = "COM11";
        een.Open();
        return een;
    }
    public static SerialPort maakpoorttwee()
    {
        SerialPort twee = new SerialPort();
        twee.BaudRate = 9600;
        twee.PortName = "COM4";
        twee.Open();
        return twee;
    }

    public String getString()
    {
        inputString = startPort.ReadTo("\r\n");
        startPort.DiscardInBuffer();
        return inputString;
    }

    public void dispenseMoney(String parameters)
    {
        dispenserPort.Write(parameters);
        dispenserPort.DiscardInBuffer();
    }

    public int getChoice()
    {
        int choice = 0;
        string choiceString = this.getString();
        if (choiceString == "AKEY") { choice = 1; }
        if (choiceString == "BKEY") { choice = 2; }
        if (choiceString == "CKEY") { choice = 3; }
        if (choiceString == "#KEY") { choice = 4; }
        if (choiceString == "$KEY") { choice = 5; }
        return choice;
    }
}

public class Executer
{
    private String rekeningID;
    private String userName;
    private String pasID;
    private ArduinoData arduino;
    private HTTPget downloadConnection = new HTTPget();
    private HTTPpost uploadConnection = new HTTPpost();
    private Rekening rekening;
    Boolean cancelled = false;
    private Boolean endOfSession = true;
    private double saldo;
    Pinscherm pinsherm = new Pinscherm();
    TicketScreen asker = new TicketScreen();

    public Executer(String r, String u, ArduinoData a, String p)
    {
        this.rekeningID = r;
        this.userName = u;
        this.arduino = a;
        this.pasID = p;
        this.rekening = downloadConnection.getRekening(rekeningID);
        this.saldo = rekening.Balans;
    }

    public Boolean getEndOfSession()
    {
        return this.endOfSession;
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
        Boolean printTicket = false;
        Boolean goBack = true;
        int amount = 0;
        String input;
        String dispenserCommand;
        cancelled = false;

        while (goBack == true)
        {
            pinsherm.Show();
            while (true)
            {
                input = arduino.getString();
                if (input.Contains("1"))
                {
                    amount = 10;
                    break;
                }
                else if (input.Contains("2"))
                {
                    amount = 20;
                    break;
                }
                else if (input.Contains("3"))
                {
                    amount = 50;
                    break;
                }
                else if (input.Contains("4"))
                {
                    amount = getAlternativeAmount();
                    break;
                }
                else if (input.Contains("#"))
                {
                    cancelled = true;
                    break;
                }
                else if (input.Contains("C"))
                {
                    cancelled = true;
                    endOfSession = false;
                    break;
                }
            }
            pinsherm.Hide();
            if (amount > saldo && amount != 0)
            {
                PinError pinError = new PinError();
                cancelled = true;
            }
            if (cancelled == true)
            {
                break;
            }
            else
            {
                double newsaldo = saldo - amount;
                int newnewsaldo = Convert.ToInt32(newsaldo);
                uploadConnection.UpdateBalans(Int32.Parse(rekeningID), (newnewsaldo));
                uploadConnection.transaction(pasID, rekeningID, amount);
                //Error.show(amount.ToString());
            }
            if (amount > 10) { dispenserCommand = biljetSelection(amount); }
            else { dispenserCommand = "01,00,00*"; }
            asker.Show();
            while (true)
            {
                input = arduino.getString();
                if (input.Contains("*"))
                {
                    printTicket = true;
                    goBack = false;
                    break;
                }
                else if (input.Contains("#"))
                {
                    //Error.show("Geen Bon", "bon");
                    goBack = false;
                    break;
                }
            }
            asker.Hide();
            arduino.dispenseMoney(dispenserCommand);
            if (printTicket == true)
            {
                Klant tmp = downloadConnection.getKlant(userName);
                String printnaam = String.Concat(tmp.voornaam + " " + tmp.achternaam);
                Printer bonPrinter = new Printer(printnaam, amount, rekeningID);
                bonPrinter.printTicket();
            }
            if (goBack == false)
            {
                ByeScreen goAway = new ByeScreen();
            }
        }
    }

    private String biljetSelection(int amount)
    {
        String choice = "00,00,00*";
        String option1;
        String option2;
        String option3 = "invalid";
        String option4 = "invalid*";
        int tens = 0;
        int twenties = 0;
        int fifties = 0;
        BiljetScreen selector = new BiljetScreen();
        tens = amount / 10;
        selector.setLabel1(tens.ToString());
        if (tens > 9) { option1 = tens.ToString() + ",00,00*"; }
        else { option1 = "0" + tens.ToString() + ",00,00*"; }
        if (amount % 20 == 0)
        {
            twenties = (amount / 20);
            tens = 0;
            option2 = generateCommand(tens, twenties, fifties);
        }
        else
        {
            twenties = (amount - (amount % 20)) / 20;
            tens = 1;
            option2 = generateCommand(tens, twenties, fifties);
        }
        selector.setLabel2(tens.ToString(), twenties.ToString());
        if (amount >= 50 && amount % 50 == 0)
        {
            tens = 0;
            twenties = 0;
            fifties = amount / 50;
            option3 = generateCommand(tens, twenties, fifties);
            selector.label4.Visible = false;
        }
        else if (amount >= 60)
        {
            tens = (amount % 50) / 10;
            twenties = 0;
            fifties = (amount - (amount % 50)) / 50;
            selector.setLabel3(tens.ToString(), fifties.ToString());
            option3 = generateCommand(tens, twenties, fifties);
            if (((amount % 50) % 20) == 0)
            {
                twenties = ((amount % 50) % 20) / 20;
                tens = 0;
            }
            else if (amount % 50 == 30)
            {
                twenties = 1;
                tens = 1;
                selector.setLabel4(tens.ToString(), twenties.ToString(), fifties.ToString());
            }
            option4 = generateCommand(tens, twenties, fifties);
        }
        selector.Show();
        Boolean validInput = false;
        int selection = 0;
        while (validInput == false)
        {
            selection = arduino.getChoice();
            if (selection == 3 && !(option3.Equals("invalid"))) { validInput = true; }
            else if (selection == 4 && !(option4.Equals("invalid"))) { validInput = true; }
            else if (selection != 0) { validInput = true; }
        }
        switch (selection)
        {
            case 1:
                choice = option1;
                break;
            case 2:
                choice = option2;
                break;
            case 3:
                choice = option3;
                break;
            case 5:
                choice = option4;
                break;
        }
        selector.Hide();
        Error.show(choice);
        return choice;
    }

    private String generateCommand(int tens, int twenties, int fifties)
    {
        String strTens = "00";
        String strTwenties = ",00";
        String strFifties = ",00";

        if (tens < 10 && tens > 0) { strTens = "0" + tens.ToString(); }
        if (twenties < 10 && twenties > 0) { strTwenties = ",0" + twenties.ToString(); }
        if (fifties < 10 && fifties > 0) { strFifties = ",0" + fifties.ToString(); }
        return strTens + strTwenties + strFifties + ",*";
    }

    private void checkSaldo()
    {
        SaldoScreen saldoDisplay = new SaldoScreen(saldo);
        saldoDisplay.Show();
        while (true)
        {
            String input = arduino.getString();
            if (input.Contains("*"))
            {
                saldoDisplay.Hide();
                pin();
                break;
            }
            else if (input.Contains("#"))
            {
                ByeScreen goAway = new ByeScreen();
                endOfSession = true;
                saldoDisplay.Close();
                break;
            }
        }
    }

    private void quickPin()
    {
        int amount = 70;
        if (amount > saldo && amount != 0)
        {
            PinError pinError = new PinError();
            cancelled = true;
        }
        uploadConnection.UpdateBalans(Int32.Parse(rekeningID), (Convert.ToInt32(saldo - amount)));
        uploadConnection.transaction(pasID, rekeningID, amount);
        if (cancelled == false) { arduino.dispenseMoney("02,00,01*"); }
        ByeScreen quickBye = new ByeScreen();
        endOfSession = true;
        quickBye.Hide();
    }

    private int getAlternativeAmount()
    {
        int customBedrag = 0;
        String bedragstring = "";
        String input;
        Boolean validInput;
        Boolean pending = true;
        Bedragselectie selector = new Bedragselectie();
        selector.Show();
        while (pending)
        {
            validInput = false;
            input = arduino.getString();
            for (int i = 0; i < 10; i++)
            {
                if (input.Contains(i.ToString()))
                {
                    validInput = true;
                }
                else if (input.Contains("*"))
                {
                    if (customBedrag > 0)
                    {
                        if (customBedrag % 10 == 0)
                        {
                            pending = false;
                            break;
                        }
                        else
                        {
                            selector.clearDisplay();
                            selector.showError();
                            break;
                        }
                    }
                }
                else if (input.Contains("C"))
                {
                    cancelled = true;
                    pending = false;
                    break;
                }
                else if (input.Contains("#"))
                {
                    cancelled = true;
                    endOfSession = true;
                    pending = false;
                    break;
                }
            }
            if (validInput)
            {
                bedragstring += input.ElementAt(0);
                customBedrag = Int32.Parse(bedragstring);
                selector.setDisplay(bedragstring);
            }
        }
        selector.Hide();
        return customBedrag;
    }
}


public class Printer
{
    private String userName;
    private String rekeningNr;
    private double amount;

    public Printer(String s, double b, String r)
    {
        this.userName = s;
        this.amount = b;
        this.rekeningNr = r;
    }

    public void printTicket()
    {
        String bedrag = amount.ToString();
        ILabel _label;
        _label = Framework.Open(@"C:\DYMO\jaja.label");
        _label.SetObjectText("Klantnaam", userName);
        _label.SetObjectText("rekeningNr", rekeningNr);
        _label.SetObjectText("bedrag", bedrag + "€");
        _label.SetObjectText("DATUM-TIJD", "");
        IPrinter printer = Framework.GetPrinters().First();
        if (printer is ILabelWriterPrinter)
        {
            ILabelWriterPrintParams printParams = null;
            ILabelWriterPrinter labelWriterPrinter = printer as ILabelWriterPrinter;
            if (labelWriterPrinter.IsTwinTurbo)
            {
                printParams = new LabelWriterPrintParams();
                printParams.RollSelection = (RollSelection)Enum.Parse(typeof(RollSelection), "koekje");
            }

            _label.Print(printer, printParams);
        }
        else
            _label.Print(printer); // print with default params
    }
}

public class Hash
{
    public bool checkHash(String RekeningID, String pincode)
    {
        int RekeningIDcv;
        int pincodecv;
        Int32.TryParse(RekeningID, out RekeningIDcv);
        Int32.TryParse(pincode, out pincodecv);
        bool status = false;
        HTTPget temporary = new HTTPget();
        string Hash = makeHash(RekeningIDcv, pincodecv);
        if (Hash == temporary.getHash(RekeningID))
        {
            status = true;
        }
        else { }
        return status;

    }
    public String makeHash(int RekeningID, int pincode)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(String.Concat(RekeningID, pincode)));
    }
    public void blockCard(String PasID)
    {

    }
}
 public class Email
  {
  
      public void SendEmail()
      {
          DateTime dt = DateTime.Now;
          String strDate = "";
          strDate = dt.ToString("dddd, dd MMMM yyyy HH:mm:ss");
          MailMessage mail = new MailMessage();
          SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
          mail.From = new MailAddress("saltysolutionsbank@gmail.com");
          mail.To.Add("rowalski_wever@hotmail.com");
          mail.Subject = "TransactieBon: "+strDate;
          mail.Body = "kijk attachment voor jouw bon!";
  
          //System.Net.Mail.Attachment attachment;
          //attachment = new System.Net.Mail.Attachment(@"C:\Users\Rowalski\Desktop\hi\wallpapers\142e94c38ca95ece.jpg");
          //mail.Attachments.Add(attachment);
  
          SmtpServer.Port = 587;
          SmtpServer.Credentials = new System.Net.NetworkCredential("saltysolutionsbank@gmail.com", "saltysalt");
          SmtpServer.EnableSsl = true;
 
         SmtpServer.Send(mail);
      }
  
   }
