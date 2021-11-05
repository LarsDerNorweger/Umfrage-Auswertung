
namespace Umfrage_Auswetung
{
   partial class MoreInformation
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
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.InfoFieldKat = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.total = new System.Windows.Forms.Label();
         this.infoFieldNumb = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // listBox1
         // 
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(29, 96);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(214, 407);
         this.listBox1.TabIndex = 0;
         this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
         // 
         // InfoFieldKat
         // 
         this.InfoFieldKat.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.InfoFieldKat.Location = new System.Drawing.Point(259, 96);
         this.InfoFieldKat.Name = "InfoFieldKat";
         this.InfoFieldKat.Size = new System.Drawing.Size(181, 407);
         this.InfoFieldKat.TabIndex = 1;
         this.InfoFieldKat.Text = "";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(25, 59);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Daten Serie";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(255, 59);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(149, 20);
         this.label2.TabIndex = 3;
         this.label2.Text = "Weitere Information";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(256, 534);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(87, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Daten Insgesamt";
         // 
         // total
         // 
         this.total.AutoSize = true;
         this.total.Location = new System.Drawing.Point(349, 534);
         this.total.Name = "total";
         this.total.Size = new System.Drawing.Size(35, 13);
         this.total.TabIndex = 5;
         this.total.Text = "label4";
         // 
         // infoFieldNumb
         // 
         this.infoFieldNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.infoFieldNumb.Location = new System.Drawing.Point(436, 96);
         this.infoFieldNumb.Name = "infoFieldNumb";
         this.infoFieldNumb.Size = new System.Drawing.Size(150, 407);
         this.infoFieldNumb.TabIndex = 6;
         this.infoFieldNumb.Text = "";
         // 
         // MoreInformation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(620, 556);
         this.ControlBox = false;
         this.Controls.Add(this.infoFieldNumb);
         this.Controls.Add(this.total);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.InfoFieldKat);
         this.Controls.Add(this.listBox1);
         this.Name = "MoreInformation";
         this.Text = "Mehr Infromationen";
         this.Load += new System.EventHandler(this.MoreInformation_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.RichTextBox InfoFieldKat;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      public System.Windows.Forms.Label total;
      private System.Windows.Forms.RichTextBox infoFieldNumb;
   }
}