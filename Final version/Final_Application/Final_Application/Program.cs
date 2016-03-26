using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
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

    public class Arduino
    {
        static SerialPort Ard = new SerialPort();
        static String portName = "COM1";
        public static bool makePort(String s)
        {
            portName = s;
            bool status = false;
            Ard.BaudRate = 9600;
            Ard.PortName = portName;
            try
            {
                Ard.Open();
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
            return Ard;
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
    public class HTTPGET
    {
        //code to get data from mysql database using HTTP GET method
    }
}
