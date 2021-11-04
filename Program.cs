using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StandartWindows;

namespace Umfrage_Auswetung
{
   static class Program
   {
      /// <summary>
      /// Der Haupteinstiegspunkt für die Anwendung.
      /// </summary>
      [STAThread]
      static void Main()
      {
         try
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(@"./config.json"));
         }
         catch(Exception e)
         {
            Error err = new Error(e.ToString());
            err.ShowDialog();
         }
      }
                                                                                                                             

   }
}
