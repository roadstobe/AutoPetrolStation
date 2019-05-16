using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Petrol> petrols = new List<Petrol>();
            petrols.Add(new Petrol("Disel", 31.74));
            petrols.Add(new Petrol("A - 95", 30.75));
            petrols.Add(new Petrol("A - 92", 29.54));
            petrols.Add(new Petrol("Biodisel", 25.7));
            petrols.Add(new Petrol("A - 100", 31.74));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(petrols));
        }
    }
}
