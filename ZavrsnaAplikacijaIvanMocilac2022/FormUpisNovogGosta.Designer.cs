
namespace ZavrsnaAplikacijaIvanMocilac2022
{
    partial class FormUpisNovogGosta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpisNovogGosta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrojSkupine = new System.Windows.Forms.TextBox();
            this.dateTimeRođenje = new System.Windows.Forms.DateTimePicker();
            this.comboZemljaPrebivališta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj skupine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zemlja prebivališta:";
            // 
            // btnUpisi
            // 
            this.btnUpisi.BackColor = System.Drawing.Color.Transparent;
            this.btnUpisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpisi.BackgroundImage")));
            this.btnUpisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpisi.Location = new System.Drawing.Point(115, 221);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(72, 85);
            this.btnUpisi.TabIndex = 9;
            this.btnUpisi.UseVisualStyleBackColor = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(45, 6);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(65, 37);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 11;
            // 
            // txtBrojSkupine
            // 
            this.txtBrojSkupine.Location = new System.Drawing.Point(86, 103);
            this.txtBrojSkupine.Name = "txtBrojSkupine";
            this.txtBrojSkupine.Size = new System.Drawing.Size(100, 20);
            this.txtBrojSkupine.TabIndex = 13;
            // 
            // dateTimeRođenje
            // 
            this.dateTimeRođenje.Location = new System.Drawing.Point(98, 69);
            this.dateTimeRođenje.Name = "dateTimeRođenje";
            this.dateTimeRođenje.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRođenje.TabIndex = 15;
            // 
            // comboZemljaPrebivališta
            // 
            this.comboZemljaPrebivališta.FormattingEnabled = true;
            this.comboZemljaPrebivališta.Location = new System.Drawing.Point(115, 138);
            this.comboZemljaPrebivališta.Name = "comboZemljaPrebivališta";
            this.comboZemljaPrebivališta.Size = new System.Drawing.Size(121, 21);
            this.comboZemljaPrebivališta.TabIndex = 16;
            // 
            // FormUpisNovogGosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 318);
            this.Controls.Add(this.comboZemljaPrebivališta);
            this.Controls.Add(this.dateTimeRođenje);
            this.Controls.Add(this.txtBrojSkupine);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpisNovogGosta";
            this.Text = "FormUpisNovogGosta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBrojSkupine;
        private System.Windows.Forms.DateTimePicker dateTimeRođenje;
        private System.Windows.Forms.ComboBox comboZemljaPrebivališta;
    }
}