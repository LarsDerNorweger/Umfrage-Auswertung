using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StandartWindows;

namespace Umfrage_Auswetung
{
   public class SettingsManager
   {
      public string m_SettingsPath { get; set; }
      public Dictionary<string,string> m_AnalyseDataPath = new Dictionary<string, string>();

      private DataOperation d_DataOperation = new DataOperation();
      
      public void LoadSettings()
      {
         string str = d_DataOperation.ReadFromFile(m_SettingsPath);
         m_AnalyseDataPath = d_DataOperation.DeconvertDataFromJSON(str);
      }
   }
}
