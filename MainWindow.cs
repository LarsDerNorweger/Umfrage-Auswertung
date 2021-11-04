using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using StandartWindows;

namespace Umfrage_Auswetung
{
   public partial class MainWindow : Form
   {
      SettingsManager m_SettingsManager = new SettingsManager();
      Settings m_Settings = new Settings();

      Analyser processData = new Analyser();
      DataOperation m_DataOperation = new DataOperation();
      
      Information inf = new Information();

      private string preSelectedItem = "";
      private string mainSelectedItem = "";
      private string xAxesItem="sex";

      private Dictionary<string,Dictionary<string,string>> AnalysePattern = new Dictionary<string, Dictionary<string, string>>();

      public MainWindow(string Settingspath)
      {
         InitializeComponent();
         m_SettingsManager.m_SettingsPath = Settingspath;
      }

      private void MainWindow_Load(object sender, EventArgs e)
      {
         m_SettingsManager.LoadSettings();

         AnalysePattern = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(m_DataOperation.ReadFromFile(@"./Analyse.json"));
         Dictionary<string, Dictionary<string, string>>.KeyCollection keys = AnalysePattern.Keys;

         processData.AnalysePattern = AnalysePattern;
         processData.Settings = m_SettingsManager.m_AnalyseDataPath;
         processData.LoadData(TestChart);

         foreach(string key in keys)
         {
            if(key == "translate")
               continue;
            xAxis.Items.Add(AnalysePattern[key]["name"]);
            preSelect.Items.Add(AnalysePattern[key]["name"]);
         }
   }

      private void SettingsButton_Click(object sender, EventArgs e)
      {
         m_Settings.AnalyseDataPath = m_SettingsManager.m_AnalyseDataPath["AnalyseDataPath"];
         m_Settings.ShowDialog();

         if(m_Settings.changedSettings)
         {
            m_SettingsManager.m_AnalyseDataPath["AnalyseDataPath"]= m_Settings.AnalyseDataPath;

            string str = m_DataOperation.ConvertDataToJSON(m_SettingsManager.m_AnalyseDataPath);
            Save svdlg = new Save(str, m_SettingsManager.m_SettingsPath);
            svdlg.ShowDialog();
            
            m_SettingsManager.LoadSettings();
         }
      }

      private void ShowChart_Click(object sender, EventArgs e)
      {
         
      }

   

      private void deleteGraph_Click(object sender, EventArgs e)
      {
         List<object> deleteList = new List<object>();

         foreach(object itemChecked in SeriesSelect.CheckedItems)
         {
            var s = TestChart.Series.FindByName(itemChecked.ToString());
            TestChart.Series.Remove(s);
            deleteList.Add(itemChecked);
         }

         if(deleteList.Count == 0)
         {
            inf.m_InfoText = "Bitte wählen Sie eine Serie zuerst aus, bevor sie sie löschen!";
            inf.ShowDialog();
         }
               
         if(deleteList.Count != 0)
            foreach(object deleteObject in deleteList)
               SeriesSelect.Items.Remove(deleteObject);
      }

      private void newGraph_Click(object sender, EventArgs e)
      {
         Entry e1 = new Entry("Geben sie den Seriennamen ein");
         e1.ShowDialog();


         if(e1.InputString == "")
         {
            inf.m_InfoText = "Um eine Serie zu erstellen,muss ein Name angegeben werden";
            inf.ShowDialog();
         }
         if(e1.InputString != "")
         {
            processData.AddDataSeries(e1.InputString, preSelectedItem, mainSelectedItem, xAxesItem);
            SeriesSelect.Items.Add(e1.InputString);


         }
      }

      private void xAxis_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox chlib = (ListBox)sender;
         xAxesItem = chlib.SelectedItem.ToString();
      }

      private void preSelect_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox chlib = (ListBox)sender;
        
         preSelectedItem = chlib.SelectedItem.ToString();
         mainSelect.Items.Clear();

         Dictionary<string,string>.KeyCollection keys = AnalysePattern[AnalysePattern["translate"][preSelectedItem]].Keys;
         foreach(string key in keys)
         {
            if(key == "name")
               continue;
            mainSelect.Items.Add(AnalysePattern[AnalysePattern["translate"][preSelectedItem]][key]);
         }
      }

      private void mainSelect_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox chlib = (ListBox)sender;
         mainSelectedItem = chlib.SelectedItem.ToString();
      }

      private void xAxis_SelectedIndexChanged_1(object sender, EventArgs e)
      {
         ListBox chlib = (ListBox)sender;
         xAxesItem = chlib.SelectedItem.ToString();
      }
   }
}
