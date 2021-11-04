﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfrage_Auswetung
{
   public class ChartHelper
   {
      public Dictionary<string, System.Windows.Forms.DataVisualization.Charting.Series> ChartSeriesName =  new Dictionary<string,System.Windows.Forms.DataVisualization.Charting.Series>();

      private System.Windows.Forms.DataVisualization.Charting.Chart m_choosenChart;
      private System.Windows.Forms.DataVisualization.Charting.ChartArea ChartAreaName =  new System.Windows.Forms.DataVisualization.Charting.ChartArea();

      public void LoadChartHelper(System.Windows.Forms.DataVisualization.Charting.Chart choosenChart)
      {
         m_choosenChart = choosenChart;
         ChartAreaName.Name = "ChartArea";
         choosenChart.ChartAreas.Add(ChartAreaName);
      }

      public void AddNewSeries(string SeriesName = null) 
      {
         if(SeriesName == null)
            throw new Exception("A Seriesname must be given");

         ChartSeriesName.Add(SeriesName, new System.Windows.Forms.DataVisualization.Charting.Series());

         ChartSeriesName[SeriesName].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
         ChartSeriesName[SeriesName].ChartArea = "ChartArea";
         ChartSeriesName[SeriesName].Name = SeriesName;

         m_choosenChart.Series.Add(ChartSeriesName[SeriesName]);
      }

      
   }
}
