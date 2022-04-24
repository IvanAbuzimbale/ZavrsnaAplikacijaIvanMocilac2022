
namespace ZavrsnaAplikacijaIvanMocilac2022
{
    partial class FormUpisNoveRezervacije
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpisNoveRezervacije));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDolazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOdlazak = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.txtBrojSkupine = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtBrojGostiju = new System.Windows.Forms.TextBox();
            this.comboObjekt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum dolaska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum odlaska:";
            // 
            // dateTimeDolazak
            // 
            this.dateTimeDolazak.Location = new System.Drawing.Point(185, 12);
            this.dateTimeDolazak.Name = "dateTimeDolazak";
            this.dateTimeDolazak.Size = new System.Drawing.Size(143, 20);
            this.dateTimeDolazak.TabIndex = 2;
            // 
            // dateTimeOdlazak
            // 
            this.dateTimeOdlazak.Location = new System.Drawing.Point(185, 48);
            this.dateTimeOdlazak.Name = "dateTimeOdlazak";
            this.dateTimeOdlazak.Size = new System.Drawing.Size(143, 20);
            this.dateTimeOdlazak.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj skupine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ime i prezime vlasnika rezervacije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj gostiju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ime objekta:";
            // 
            // btnUpisi
            // 
            this.btnUpisi.BackColor = System.Drawing.Color.Transparent;
            this.btnUpisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpisi.BackgroundImage")));
            this.btnUpisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpisi.Location = new System.Drawing.Point(138, 234);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(72, 85);
            this.btnUpisi.TabIndex = 8;
            this.btnUpisi.UseVisualStyleBackColor = false;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // txtBrojSkupine
            // 
            this.txtBrojSkupine.Location = new System.Drawing.Point(185, 90);
            this.txtBrojSkupine.Name = "txtBrojSkupine";
            this.txtBrojSkupine.Size = new System.Drawing.Size(100, 20);
            this.txtBrojSkupine.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(185, 120);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 10;
            // 
            // txtBrojGostiju
            // 
            this.txtBrojGostiju.Location = new System.Drawing.Point(185, 147);
            this.txtBrojGostiju.Name = "txtBrojGostiju";
            this.txtBrojGostiju.Size = new System.Drawing.Size(100, 20);
            this.txtBrojGostiju.TabIndex = 11;
            // 
            // comboObjekt
            // 
            this.comboObjekt.FormattingEnabled = true;
            this.comboObjekt.Location = new System.Drawing.Point(185, 176);
            this.comboObjekt.Name = "comboObjekt";
            this.comboObjekt.Size = new System.Drawing.Size(121, 21);
            this.comboObjekt.TabIndex = 12;
            // 
            // FormUpisNoveRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 331);
            this.Controls.Add(this.comboObjekt);
            this.Controls.Add(this.txtBrojGostiju);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtBrojSkupine);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeOdlazak);
            this.Controls.Add(this.dateTimeDolazak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpisNoveRezervacije";
            this.Text = "Upis nove rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDolazak;
        private System.Windows.Forms.DateTimePicker dateTimeOdlazak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.TextBox txtBrojSkupine;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtBrojGostiju;
        private System.Windows.Forms.ComboBox comboObjekt;
    }
}