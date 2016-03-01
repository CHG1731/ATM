using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ATM
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
            Application.Run(new Form1());
        }
    }
    public static class Arduino
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

}
public static class Error
{
    public static void show(String s, String x)
    {
        MessageBox.Show(s, x,
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}