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
      public Dictionary<string,string> Translationpattern = new Dictionary<string, string>();
      public Dictionary<string,string> Settings = new Dictionary<string,string>();
      public DataOperation m_DataOperation = new DataOperation();


      private Dictionary<int,Dictionary<string,string>> Custumers = new Dictionary<int,Dictionary<string,string>>();
      private List<int> PreSortedList = new List<int>();

      private Dictionary<int, Dictionary<string, string>>.KeyCollection PersonNumber;


      public void LoadData()
      {
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

      public void AddDataSeries(System.Windows.Forms.DataVisualization.Charting.Chart ChartName, string preSortItem, string mainSortItem, string xAxisItem)
      {

         StartAnalyse(preSortItem, mainSortItem);
         return;
      }

      private void SplitforxAxis(string xAxisItem)
      {

         return;
      }

      private int CountforXAxis(List<int> toCountList)
      {

         return 0;
      }

      public void StartAnalyse(string preSortItem, string mainSortItem)
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
