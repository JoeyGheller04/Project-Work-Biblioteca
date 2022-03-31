using System;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm1());
        }
    }
}
