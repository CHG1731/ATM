using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYMO.Label.Framework;

namespace ConsoleApplication4
{
    class PrintTest
    {

        static void Main(string[] args)
        {
            ILabel _label;
            _label = Framework.Open(@"C:\Dymo\ATM.label");
            _label.SetObjectText("Klantnaam", "Ik ben een koekje");
            _label.SetObjectText("bedrag", "honderdmilljoenmiljard");
            _label.SetObjectText("DATUM-TIJD", "limbo");
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
}
