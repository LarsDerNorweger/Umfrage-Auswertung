using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umfrage_Auswetung
{
   public partial class Settings : Form
   {
      public bool changedSettings = false;
      public string AnalyseDataPath;

      public Settings()
      {
         InitializeComponent();
      }

      private void cancle_Click(object sender, EventArgs e)
      {
         changedSettings = false;
         this.Close();
      }

      private void save_Click(object sender, EventArgs e)
      {
         AnalyseDataPath = DataSourceEntry.Text;
         changedSettings = true;
         this.Close();
      }

      private void Settings_Load(object sender, EventArgs e)
      {
         DataSourceEntry.Text = AnalyseDataPath;
      }
   }
}
