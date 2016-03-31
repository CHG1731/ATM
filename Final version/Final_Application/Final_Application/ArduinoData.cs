using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Final_Application
{
    class ArduinoData
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
            string choiceString = getString();
            if (choiceString == "a") { choice = 1; }
            if (choiceString == "b") { choice = 2; }
            if (choiceString == "c") { choice = 3; }
            if (choiceString == "d") { choice = 4; }
            return choice;
        }

        public int getUser()
        {
            int userID = 0;
            return userID;
        }
    }
}
