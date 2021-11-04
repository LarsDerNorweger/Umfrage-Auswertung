
namespace Umfrage_Auswetung
{
   partial class Settings
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
         this.DataSourceEntry = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.save = new System.Windows.Forms.Button();
         this.cancle = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // DataSourceEntry
         // 
         this.DataSourceEntry.Location = new System.Drawing.Point(115, 16);
         this.DataSourceEntry.Name = "DataSourceEntry";
         this.DataSourceEntry.Size = new System.Drawing.Size(373, 20);
         this.DataSourceEntry.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(142, 25);
         this.label1.TabIndex = 1;
         this.label1.Text = "Einstellungen";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(10, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(99, 20);
         this.label2.TabIndex = 2;
         this.label2.Text = "Data Source";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.DataSourceEntry);
         this.groupBox1.Location = new System.Drawing.Point(38, 57);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(505, 48);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         // 
         // save
         // 
         this.save.Location = new System.Drawing.Point(495, 137);
         this.save.Name = "save";
         this.save.Size = new System.Drawing.Size(75, 23);
         this.save.TabIndex = 5;
         this.save.Text = "Speichern";
         this.save.UseVisualStyleBackColor = true;
         this.save.Click += new System.EventHandler(this.save_Click);
         // 
         // cancle
         // 
         this.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cancle.Location = new System.Drawing.Point(17, 137);
         this.cancle.Name = "cancle";
         this.cancle.Size = new System.Drawing.Size(75, 23);
         this.cancle.TabIndex = 6;
         this.cancle.Text = "Abbrechen";
         this.cancle.UseVisualStyleBackColor = true;
         this.cancle.Click += new System.EventHandler(this.cancle_Click);
         // 
         // Settings
         // 
         this.AcceptButton = this.save;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cancle;
         this.ClientSize = new System.Drawing.Size(584, 179);
         this.Controls.Add(this.cancle);
         this.Controls.Add(this.save);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Settings";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.Text = "Form3";
         this.TopMost = true;
         this.Load += new System.EventHandler(this.Settings_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox DataSourceEntry;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button save;
      private System.Windows.Forms.Button cancle;
   }
}