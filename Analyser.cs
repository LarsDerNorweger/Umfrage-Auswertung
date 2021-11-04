using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StandartWindows;

namespace Umfrage_Auswetung
{
   public class Analyser
   {
      public Dictionary<string,Dictionary<string,string>> AnalysePattern = new Dictionary<string, Dictionary<string, string>>();
      public Dictionary<string,string> Settings = new Dictionary<string,string>();
      
      private DataOperation m_DataOperation = new DataOperation();
      private ChartHelper chartHelper = new ChartHelper();

      private Dictionary<string,string> Translationpattern = new Dictionary<string, string>();
      private Dictionary<int,Dictionary<string,string>> Custumers = new Dictionary<int,Dictionary<string,string>>();
      private List<int> PreSortedList = new List<int>();

      private Dictionary<int, Dictionary<string, string>>.KeyCollection PersonNumber;


      public void LoadData(System.Windows.Forms.DataVisualization.Charting.Chart ChartName)
      {
         chartHelper.LoadChartHelper(ChartName);
         Translationpattern = AnalysePattern["translate"];

         Dictionary<string,string> PersonData = new Dictionary<string,string>();
         string newPath;

         for(int i = 0; ; i++)
         {
            newPath = m_DataOperation.getnextFilename(Settings["AnalyseDataPath"]);
            if(newPath == "")
               break;

            PersonData = m_DataOperation.DeconvertDataFromJSON(m_DataOperation.ReadFromFile(newPath));
            Custumers.Add(i, PersonData);
         }
         PersonNumber = Custumers.Keys;
      }

      public void AddDataSeries(string Seriesname, string preSortItem, string mainSortItem, string xAxisItem)
      {
         PreSortedList.Clear();

         StartAnalyse(preSortItem, mainSortItem);
         Dictionary<string,int> yValues = SplitforxAxis(xAxisItem);
         Dictionary<string,int>.KeyCollection xKeys = yValues.Keys;

         chartHelper.AddNewSeries(Seriesname);

         var s = chartHelper.selectedChart.Series.FindByName(Seriesname);
         foreach(string x in xKeys)
            s.Points.AddXY(AnalysePattern[translateItem(xAxisItem)][x], yValues[x]);
          
         chartHelper.selectedChart.Invalidate();
         return;
      }

      private Dictionary<string,int> SplitforxAxis(string xAxisItem)
      {
         xAxisItem = translateItem(xAxisItem);

         Dictionary<string, int> xValues = new Dictionary<string, int>();
         Dictionary<string,string>.KeyCollection allxValues = AnalysePattern[xAxisItem].Keys;
         string temp;


         foreach (string str in allxValues)
            if(str != "name")
               xValues.Add(str, 0);


         foreach(int i in PreSortedList)
         {
            temp = Custumers[i][xAxisItem];
            xValues[temp]++;
         }
         return xValues;
      }

      private int CountforXAxis(List<int> toCountList)
      {

         return 0;
      }

      private void StartAnalyse(string preSortItem, string mainSortItem)
      {
         if(mainSortItem == "")
            foreach(int person in PersonNumber)
              PreSortedList.Add(person);

         buildSortedList(translateItem(preSortItem),translateItem(mainSortItem));
         return;
      }

      private void buildSortedList(string presort, string mainsort)
      {
         foreach(int person in PersonNumber)
            if(Custumers[person][presort] == mainsort)
               PreSortedList.Add(person);
         return;
      }

      private string translateItem(string toTranslateItem)
      {
         if(toTranslateItem == "")
            return toTranslateItem;
         return Translationpattern[toTranslateItem];
      }



   }


}
