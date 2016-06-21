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
//using DYMO.Label.Framework;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Security.Cryptography;

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

public static class Error
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
        Pas tmp = getPasObject(pasID).Result;
        Boolean result = false;
        if (tmp != null)
        {
            if (tmp.actief == 1)
            {
                result = true;
            }
        }
        return result;
    }

    public Pas getPinclass(String s)
    {
        Pas tmp = getPasObject(s).Result;
        return tmp;
    }
    public int getFalsePinnr(String s)
    {
        Pas tmp = getPasObject(s).Result;
        return tmp.poging;
    }
    public Klant getKlant(string loc)
    {
        Klant result = getKlantObject(loc).Result;
        return result;

    }
    public int getKlantID(string s)
    {
        Pas tmp = getPasObject(s).Result;
        return tmp.klantID;
    }
    public Rekening getRekening(string s)
    {
        Rekening result = getRekeningObject(s).Result;
        return result;
    }
    public String getHash(String RekeningID)
    {
        Rekening result = getRekeningObject(RekeningID).Result;
        return result.hash;
    }
    private async Task<Klant> getKlantObject(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(string.Concat("/api/klants/", loc)).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)//Als het lukt
            {
                Klant klant = await response.Content.ReadAsAsync<Klant>();
                return klant;
            }
            else
            {
                return null;
            }
        }
    }
    private async Task<Pas> getPasObject(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(string.Concat("/api/pass/", loc)).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)//Als het lukt
            {
                Pas pas = await response.Content.ReadAsAsync<Pas>();
                return pas;
            }
            else
            {
                return null;
            }
        }
    }
    private async Task<Rekening> getRekeningObject(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(string.Concat("/api/rekenings/", loc)).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)//Als het lukt
            {
                Rekening rekening = await response.Content.ReadAsAsync<Rekening>();
                return rekening;
            }
            else
            {
                return null;
            }
        }
    }
}

public class HTTPpost
{
    public void transaction(String PasID, String RekeningID, int Balans)//UPDATED
    {
        Transactie(PasID, RekeningID, Balans).Wait();
    }
    public void resetfalsepin(String PasID)//UPDATED
    {
        resetFalsePin(PasID).Wait();
    }
    public void blockcard(string PasID)//UPDATED
    {
        BlockPin(PasID).Wait();
    }
    public void Incrementfalsepin(String PasID)//UPDATED
    {
        HTTPget tmp = new HTTPget();
        int nrfalsepin = tmp.getFalsePinnr(PasID);
        nrfalsepin++;
        if (nrfalsepin < 3)
        {
            setFalsePin(PasID).Wait();
        }
        else
        {
            blockcard(PasID);
        }
    }
    public void UpdateBalans(string RekeningID, int balans) //UPDATED
    {
        UpdateBalanz(RekeningID, balans).Wait();
    }

    //==========================
    private async Task setFalsePin(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HTTPget tmp = new HTTPget();
            Pas uploadobject = tmp.getPinclass(loc);
            int npoging = uploadobject.poging; npoging++;
            uploadobject.poging = npoging;
            HttpResponseMessage response = await client.PutAsJsonAsync(String.Concat("/api/pass/", loc), uploadobject).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("SUCCES");
            }
            else
            {
                //Error.show("FAIL");
            }
        }
    }
    private async Task resetFalsePin(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HTTPget tmp = new HTTPget();
            Pas uploadobject = tmp.getPinclass(loc);
            uploadobject.poging = 0;
            HttpResponseMessage response = await client.PutAsJsonAsync(String.Concat("/api/pass/", loc), uploadobject).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("SUCCES");
            }
            else
            {
                //Error.show("FAIL");
            }
        }
    }
    private async Task BlockPin(string loc)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HTTPget tmp = new HTTPget();
            Pas uploadobject = tmp.getPinclass(loc);
            uploadobject.actief = 0;
            HttpResponseMessage response = await client.PutAsJsonAsync(String.Concat("/api/pass/", loc), uploadobject).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("SUCCES");
            }
            else
            {
                //Error.show("FAIL");
            }
        }
    }
    private async Task UpdateBalanz(string RekeningID, int nbalans)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HTTPget tmp = new HTTPget();
            Rekening uploadobject = tmp.getRekening(RekeningID);
            uploadobject.balans = nbalans;
            HttpResponseMessage response = await client.PutAsJsonAsync(String.Concat("/api/rekenings/", RekeningID), uploadobject).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("SUCCES");
            }
            else
            {
                //Error.show("FAIL");
            }
        }
    }
    private async Task Transactie(String PasID, String RekeningID, int balans)
    {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        using (var client = new HttpClient(new HttpClientHandler { UseProxy = false, ClientCertificateOptions = ClientCertificateOption.Automatic }))
        {
            client.BaseAddress = new Uri("https://hrsqlapp.tk");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var trans = new Transactie() { Balans = balans, PasID = Int32.Parse(PasID), RekeningID = RekeningID, locatie = "HRO" };
            HttpResponseMessage response = await client.PostAsJsonAsync("api/transacties", trans).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //Error.show("SUCCES");
            }
            else
            {
                //Error.show("FAIL");
            }
        }
    }
    //======================
}

public class Klant
{
    public int klantID { get; set; }
    public string voornaam { get; set; }
    public string achternaam { get; set; }
    public string email { get; set; }
}
public class Pas
{
    public int pasID { get; set; }
    public int poging { get; set; }
    public int actief { get; set; }
    public int klantID { get; set; }
    public string rekeningID { get; set; }
}
public class Rekening
{
    public string rekeningID { get; set; }
    public int balans { get; set; }
    public string hash { get; set; }
}
public class Transactie
{
    public string RekeningID { get; set; }
    public int Balans { get; set; }
    public int PasID { get; set; }
    public string locatie { get; set; }
}
public class ArduinoData
{
    static string comuno = string.Concat("COM",COMINFO.com1);
    static string comdos = string.Concat("COM",COMINFO.com2);
    SerialPort startPort = maakpoorteen();
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
        een.PortName = comuno;
        een.Open();
        return een;
    }
    public static SerialPort maakpoorttwee()
    {
        SerialPort twee = new SerialPort();
        twee.BaudRate = 9600;
        twee.PortName = comdos;
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

public class TransactionManager
{
    private String rekeningID;
    private String userName;
    private String pasID;
    private int klantID;
    private ArduinoData arduino;
    private HTTPget downloadConnection = new HTTPget();
    private HTTPpost uploadConnection = new HTTPpost();
    private Rekening rekening;
    private Stock stock;
    Boolean cancelled = false;
    private Boolean endOfSession = true;
    private int saldo;
    Pinscherm pinsherm = new Pinscherm();
    TicketScreen asker = new TicketScreen();

    public TransactionManager(String r, int u, ArduinoData a, String p, Stock s)
    {
        this.rekeningID = r;
        this.klantID = u;
        this.userName = downloadConnection.getKlant(klantID.ToString()).achternaam;
        this.arduino = a;
        this.pasID = p;
        this.rekening = downloadConnection.getRekening(rekeningID);
        this.saldo = rekening.balans;
        this.stock = s;
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
        String dispenserCommand = "00,00,00,*";
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
            if ((amount > saldo && amount != 0) || amount >= 200)
            {
                PinError pinError = new PinError();
                cancelled = true;
            }
            if (cancelled == true)
            {
                break;
            }
            if (amount == 10 && stock.checkIfAvailable(1, 0 , 0) == true)
            {
                dispenserCommand = "01,00,00,*";
            }
            else
            {
                cancelled = true;
            }
            if (amount > 10)
            {
                dispenserCommand = biljetSelection(amount);
                if (dispenserCommand.Equals("00,00,00,*"))
                {
                    cancelled = true;
                    break;
                }
            }
            if (cancelled == true) { break; }
            uploadConnection.UpdateBalans(rekeningID, (saldo - amount*100));
            uploadConnection.transaction(pasID, rekeningID, amount);
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
                    goBack = false;
                    break;
                }
                else if (input.Contains("A"))
                {
                    Email mailer = new Email(userName, amount, rekeningID,klantID);
                    mailer.sendEmail();
                    goBack = false;
                    break;
                }
            }
            asker.Hide();
            stock.substractBiljets(dispenserCommand);
            arduino.dispenseMoney(dispenserCommand);
            if (printTicket == true)
            {
                Printer bonPrinter = new Printer(userName, amount, rekeningID);
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
        String choice = "00,00,00,*";
        String option1 = "invalid";
        String option2 = "invalid";
        String option3 = "invalid";
        String option4 = "invalid";
        Boolean validInput = false;
        int selection = 0;
        int tens = 0;
        int twenties = 0;
        int fifties = 0;
        BiljetScreen selector = new BiljetScreen();
        tens = amount / 10;
        if (stock.checkIfAvailable(tens, twenties, fifties))
        {
            selector.setLabel1(tens.ToString());
            if (tens > 9) { option1 = tens.ToString() + ",00,00,*"; }
            else { option1 = "0" + tens.ToString() + ",00,00,*"; }
        }
        if (amount % 20 == 0)
        {
            twenties = (amount / 20);
            tens = 0;
            fifties = 0;
            option2 = generateCommand(tens, twenties, fifties);
        }
        else
        {
            twenties = (amount - (amount % 20)) / 20;
            tens = 1;
            fifties = 0;
            option2 = generateCommand(tens, twenties, fifties);
        }
        if (!(option2.Equals("invalid")))
        {
            selector.setLabel2(tens.ToString(), twenties.ToString());
        }
        if (amount >= 50 && amount % 50 == 0)
        {
            tens = 0;
            twenties = 0;
            fifties = amount / 50;
            option3 = generateCommand(tens, twenties, fifties);
            if (!(option3.Equals("invalid")))
            {
                selector.setLabel3(tens.ToString(), fifties.ToString());
            }
        }
        else if (amount >= 60)
        {
            tens = (amount % 50) / 10;
            twenties = 0;
            fifties = (amount - (amount % 50)) / 50;
            option3 = generateCommand(tens, twenties, fifties);
            if (!(option3.Equals("invalid")))
            {
                selector.setLabel3(tens.ToString(), fifties.ToString());
            }
            if (((amount % 50) % 20) == 0)
            {
                twenties = ((amount % 50) % 20) / 20;
                tens = 0;
            }
            else if (amount % 50 == 30)
            {
                twenties = 1;
                tens = 1;
            }
            option4 = generateCommand(tens, twenties, fifties);
            if (!(option4.Equals("invalid")))
            {
                selector.setLabel4(tens.ToString(), twenties.ToString(), fifties.ToString());
            }
        }
        selector.Show();
        if (option1.Equals("invalid") && option2.Equals("invalid") && option3.Equals("invalid") && option4.Equals("invalid"))
        {
            selector.showInsufficient();
        }
        else
        {
            //Error.show(option1 + " " + option2 + " " + option3 + "" + option4);
            while (validInput == false)
            {
                selection = arduino.getChoice();
                if (selection == 1 && !(option1.Equals("invalid"))) { validInput = true; }
                else if (selection == 2 && !(option2.Equals("invalid"))) { validInput = true; }
                else if (selection == 3 && !(option3.Equals("invalid"))) { validInput = true; }
                else if (selection == 5 && !(option4.Equals("invalid"))) { validInput = true; }
                else if (selection == 4)
                {
                    cancelled = true;
                    break;
                }
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
        }
        selector.Hide();
        //Error.show(choice);
        return choice;
    }

    private String generateCommand(int tens, int twenties, int fifties)
    {
        String strTens = "00";
        String strTwenties = ",00";
        String strFifties = ",00";
        String command = "";

        if (tens < 10 && tens > 0) { strTens = "0" + tens.ToString(); }
        if (twenties < 10 && twenties > 0) { strTwenties = ",0" + twenties.ToString(); }
        if (fifties < 10 && fifties > 0) { strFifties = ",0" + fifties.ToString(); }
        command = strTens + strTwenties + strFifties + ",*";
        if (stock.checkIfAvailable(tens, twenties, fifties) == true)
        {
            return command;
        }
        else
        {
            return "invalid";
        }
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
        String dispenserCommand = "";
        if (amount > saldo)
        {
            PinError pinError = new PinError();
            cancelled = true;
        }
        if(stock.checkIfAvailable(2, 0, 1))
        {
            dispenserCommand = "02,00,01,*";
        }
        else if(stock.checkIfAvailable(0, 1, 1))
        {
            dispenserCommand = "00,01,01,*";
        }
        else if(stock.checkIfAvailable(1, 3, 0))
        {
            dispenserCommand = "01,03,00,*";
        }
        else if(stock.checkIfAvailable(7,0,0))
        {
            dispenserCommand = "07,00,00,*";
        }
        else
        {
            cancelled = true;
        }
        if (cancelled == false)
        {
            stock.substractBiljets(dispenserCommand);
            uploadConnection.UpdateBalans(rekeningID, (saldo - amount * 100));
            uploadConnection.transaction(pasID, rekeningID, amount);
            arduino.dispenseMoney(dispenserCommand);
        }
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
                    if (customBedrag > 0 && customBedrag <= 1000)
                    {
                        if (customBedrag % 10 == 0)
                        {
                            pending = false;
                            break;
                        }
                        else
                        {
                            bedragstring = "";
                            selector.clearDisplay();
                            selector.showError(1);
                            break;
                        }
                    }
                    else
                    {
                        bedragstring = "";
                        selector.clearDisplay();
                        selector.showError(2);
                        break;
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

public class Stock
{
    private int tensInStock = 0;
    private int twentiesInStock = 0;
    private int fiftiesInStock = 0;
    Boolean available = false;
    ArduinoData arduino;

    public Stock(ArduinoData a)
    {
        this.arduino = a;
    }

    public Boolean checkIfAvailable(int tens, int twenties, int fifties)
    {
        available = false;
        if (tensInStock == 0 && twentiesInStock == 0 && fiftiesInStock == 0)
        {
            return available;
        }
        if (tens > tensInStock) { return available; }
        else if (twenties > twentiesInStock) { return available; }
        else if (fifties > fiftiesInStock) { return available; }
        else
        {
            available = true;
            return available;
        }
    }

    public void substractBiljets(String amount)
    {
        String[] order = new String[3];
        order = amount.Split(',', ',', ',');
        tensInStock -= Int32.Parse(order[0]);
        twentiesInStock -= Int32.Parse(order[1]);
        fiftiesInStock -= Int32.Parse(order[2]);
        //Error.show("" + tensInStock + " " + twentiesInStock + " " + fiftiesInStock);
    }

    public void restock()
    {
        StockScreen stockScreen = new StockScreen(this);
        stockScreen.ShowDialog();
    }

    public void setBiljets(int tens, int twenties, int fifties)
    {
        this.tensInStock += tens;
        this.twentiesInStock += twenties;
        this.fiftiesInStock += fifties;
    }

    public void showStock()
    {
        //Error.show("" + tensInStock + " " + twentiesInStock + " " + fiftiesInStock);
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
        /*
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
            */
    }
}

public class Hash
{
    public bool checkHash(String RekeningID, String pincode)
    {
        HTTPget x = new HTTPget();
        bool status = false;
        string hashcheck = x.getRekening(RekeningID).hash;
        if(hashcheck.Equals(makeHash(RekeningID,pincode)))
        {
            status = true;
        }
        return status;
    }
    public String makeHash(String RekeningID, String pincode)
    {
        string input = String.Concat(RekeningID,pincode);
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        SHA512Managed hashstring = new SHA512Managed();
        byte[] hash = hashstring.ComputeHash(bytes);
        string hashString = string.Empty;
        foreach (byte x in hash)
        {
            hashString += String.Format("{0:x2}", x);
        }
        return hashString;
    }
}

public class Email
{

    private String userName;
    private String rekeningNr;
    private double amount;
    private string email;

    public Email(String s, double b, String r,int klantid)
    {
        this.userName = s;
        this.amount = b;
        this.rekeningNr = r;
        HTTPget x = new HTTPget();
        Klant tmp = x.getKlant(klantid.ToString());
        email = tmp.email;
    }

    public void sendEmail()
    {
        DateTime dt = DateTime.Now;
        String strDate = "";
        strDate = dt.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("saltysolutionsbank@gmail.com");
        mail.To.Add(email);
        mail.Subject = "TransactieBon: " + strDate;
        mail.Body = "Geachte Meneer/Mevrouw: "+userName+ "\nOpname van: "+amount+"\nRekeningnummer: "+rekeningNr;
        mail.AlternateViews.Add(getEmbeddedImage(@"C:\DYMO\indexlogo.png"));
        /*
        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(@"C:\Users\Rowalski\Desktop\hi\wallpapers\142e94c38ca95ece.jpg");
        mail.Attachments.Add(attachment);
        */
        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("saltysolutionsbank@gmail.com", "saltysalt");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
    }
    private AlternateView getEmbeddedImage(String filePath)
    {
        LinkedResource inline = new LinkedResource(filePath);
        inline.ContentId = Guid.NewGuid().ToString();
        string htmlBody = "Geachte Heer/Mevrouw " + userName + "<br>Opname van: " + amount + "€<br>Rekeningnummer: " + rekeningNr + "<br>" + "<br>" + "<br>" + "<br>" + "Bedankt voor uw transactie" + "<br>" + "<br>" + "Met vriendelijke groet," + "<br>" + "Salty Solutions Bank" + "<br>" + @"<img src='cid:" + inline.ContentId + @"'/>";
        AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
        alternateView.LinkedResources.Add(inline);
        return alternateView;
    }
}
static class COMINFO
{
    public static string com1;
    public static string com2;
}