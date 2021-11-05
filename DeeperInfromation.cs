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
   public partial class MoreInformation : Form
   {
      public Dictionary<string,Dictionary<string,int>> Data = new Dictionary<string, Dictionary<string, int>>();

      public MoreInformation()
      {
         InitializeComponent();
      }

      public void UpdateContent()
      {
         InfoFieldKat.Clear();
         infoFieldNumb.Clear();
         listBox1.Items.Clear();

         foreach(string key in Data.Keys)
            listBox1.Items.Add(key);
         return;
      }

      private void MoreInformation_Load(object sender, EventArgs e)
      {
         UpdateContent();
      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox chlib = (ListBox)sender;
         InfoFieldKat.Clear();
         infoFieldNumb.Clear();

         int tot = 0;

         infoFieldNumb.Text = "Anzahl\n";
         InfoFieldKat.Text = "Kategorie\n";

         Dictionary<string,int>.KeyCollection keys = Data[chlib.SelectedItem.ToString()].Keys;
         foreach(string key in keys)
         {
            infoFieldNumb.Text += Data[chlib.SelectedItem.ToString()][key].ToString()+"\n";
            InfoFieldKat.Text += key+"\n";
            tot +=   Data[chlib.SelectedItem.ToString()][key];
         }
         infoFieldNumb.Text += "\n"+tot.ToString();
         InfoFieldKat.Text += "\nSumme\n";
      }

      private void Cancle_Click(object sender, EventArgs e)
      {
         
      }
   }
}
