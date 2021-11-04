
namespace Umfrage_Auswetung
{
   partial class MainWindow
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.TestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.SettingsButton = new System.Windows.Forms.Button();
         this.ShowChart = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.newGraph = new System.Windows.Forms.Button();
         this.delete = new System.Windows.Forms.Button();
         this.SeriesSelect = new System.Windows.Forms.CheckedListBox();
         this.label3 = new System.Windows.Forms.Label();
         this.button3 = new System.Windows.Forms.Button();
         this.advanced = new System.Windows.Forms.GroupBox();
         this.basics = new System.Windows.Forms.GroupBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.mainSelect = new System.Windows.Forms.ListBox();
         this.preSelect = new System.Windows.Forms.ListBox();
         this.xAxis = new System.Windows.Forms.ListBox();
         ((System.ComponentModel.ISupportInitialize)(this.TestChart)).BeginInit();
         this.basics.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.SuspendLayout();
         // 
         // TestChart
         // 
         this.TestChart.Location = new System.Drawing.Point(31, 12);
         this.TestChart.Name = "TestChart";
         this.TestChart.Size = new System.Drawing.Size(793, 702);
         this.TestChart.TabIndex = 0;
         this.TestChart.Text = "chart1";
         // 
         // SettingsButton
         // 
         this.SettingsButton.Location = new System.Drawing.Point(1155, 705);
         this.SettingsButton.Name = "SettingsButton";
         this.SettingsButton.Size = new System.Drawing.Size(81, 23);
         this.SettingsButton.TabIndex = 1;
         this.SettingsButton.Text = "Einstellungen";
         this.SettingsButton.UseVisualStyleBackColor = true;
         this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
         // 
         // ShowChart
         // 
         this.ShowChart.Location = new System.Drawing.Point(6, 18);
         this.ShowChart.Name = "ShowChart";
         this.ShowChart.Size = new System.Drawing.Size(75, 23);
         this.ShowChart.TabIndex = 2;
         this.ShowChart.Text = "Anzeigen";
         this.ShowChart.UseVisualStyleBackColor = true;
         this.ShowChart.Click += new System.EventHandler(this.ShowChart_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(3, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(61, 18);
         this.label1.TabIndex = 3;
         this.label1.Text = "x-Achse";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(176, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(74, 18);
         this.label2.TabIndex = 4;
         this.label2.Text = "pre Select";
         // 
         // newGraph
         // 
         this.newGraph.Location = new System.Drawing.Point(90, 18);
         this.newGraph.Name = "newGraph";
         this.newGraph.Size = new System.Drawing.Size(75, 23);
         this.newGraph.TabIndex = 9;
         this.newGraph.Text = "neuer Graph";
         this.newGraph.UseVisualStyleBackColor = true;
         this.newGraph.Click += new System.EventHandler(this.newGraph_Click);
         // 
         // delete
         // 
         this.delete.Location = new System.Drawing.Point(9, 18);
         this.delete.Name = "delete";
         this.delete.Size = new System.Drawing.Size(75, 23);
         this.delete.TabIndex = 10;
         this.delete.Text = "Löschen";
         this.delete.UseVisualStyleBackColor = true;
         this.delete.Click += new System.EventHandler(this.deleteGraph_Click);
         // 
         // SeriesSelect
         // 
         this.SeriesSelect.FormattingEnabled = true;
         this.SeriesSelect.Location = new System.Drawing.Point(9, 53);
         this.SeriesSelect.Name = "SeriesSelect";
         this.SeriesSelect.Size = new System.Drawing.Size(307, 229);
         this.SeriesSelect.TabIndex = 11;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(6, 16);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(65, 18);
         this.label3.TabIndex = 12;
         this.label3.Text = "Graphen";
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(87, 18);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 13;
         this.button3.Text = "Verstecken";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // advanced
         // 
         this.advanced.Location = new System.Drawing.Point(195, 295);
         this.advanced.Name = "advanced";
         this.advanced.Size = new System.Drawing.Size(170, 50);
         this.advanced.TabIndex = 14;
         this.advanced.TabStop = false;
         // 
         // basics
         // 
         this.basics.Controls.Add(this.delete);
         this.basics.Controls.Add(this.newGraph);
         this.basics.Location = new System.Drawing.Point(15, 295);
         this.basics.Name = "basics";
         this.basics.Size = new System.Drawing.Size(174, 49);
         this.basics.TabIndex = 15;
         this.basics.TabStop = false;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.basics);
         this.groupBox3.Controls.Add(this.advanced);
         this.groupBox3.Controls.Add(this.label3);
         this.groupBox3.Controls.Add(this.SeriesSelect);
         this.groupBox3.Location = new System.Drawing.Point(865, 12);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(371, 350);
         this.groupBox3.TabIndex = 16;
         this.groupBox3.TabStop = false;
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.mainSelect);
         this.groupBox4.Controls.Add(this.preSelect);
         this.groupBox4.Controls.Add(this.xAxis);
         this.groupBox4.Controls.Add(this.label2);
         this.groupBox4.Controls.Add(this.label1);
         this.groupBox4.Location = new System.Drawing.Point(865, 368);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(334, 295);
         this.groupBox4.TabIndex = 17;
         this.groupBox4.TabStop = false;
         // 
         // mainSelect
         // 
         this.mainSelect.FormattingEnabled = true;
         this.mainSelect.Location = new System.Drawing.Point(175, 165);
         this.mainSelect.Name = "mainSelect";
         this.mainSelect.Size = new System.Drawing.Size(115, 108);
         this.mainSelect.TabIndex = 20;
         this.mainSelect.SelectedIndexChanged += new System.EventHandler(this.mainSelect_SelectedIndexChanged);
         // 
         // preSelect
         // 
         this.preSelect.FormattingEnabled = true;
         this.preSelect.Location = new System.Drawing.Point(175, 50);
         this.preSelect.Name = "preSelect";
         this.preSelect.Size = new System.Drawing.Size(115, 95);
         this.preSelect.TabIndex = 19;
         this.preSelect.SelectedIndexChanged += new System.EventHandler(this.preSelect_SelectedIndexChanged);
         // 
         // xAxis
         // 
         this.xAxis.FormattingEnabled = true;
         this.xAxis.Location = new System.Drawing.Point(24, 53);
         this.xAxis.Name = "xAxis";
         this.xAxis.Size = new System.Drawing.Size(118, 225);
         this.xAxis.TabIndex = 18;
         this.xAxis.SelectedIndexChanged += new System.EventHandler(this.xAxis_SelectedIndexChanged_1);
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1248, 740);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.SettingsButton);
         this.Controls.Add(this.TestChart);
         this.Name = "MainWindow";
         this.Text = "Auswertung der Umfrage";
         this.Load += new System.EventHandler(this.MainWindow_Load);
         ((System.ComponentModel.ISupportInitialize)(this.TestChart)).EndInit();
         this.basics.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataVisualization.Charting.Chart TestChart;
      private System.Windows.Forms.Button SettingsButton;
      private System.Windows.Forms.Button ShowChart;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button newGraph;
      private System.Windows.Forms.Button delete;
      private System.Windows.Forms.CheckedListBox SeriesSelect;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.GroupBox advanced;
      private System.Windows.Forms.GroupBox basics;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.ListBox xAxis;
      private System.Windows.Forms.ListBox mainSelect;
      private System.Windows.Forms.ListBox preSelect;
   }
}