
namespace ZavrsnaAplikacijaIvanMocilac2022
{
    partial class FormaNeZaAdmina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaNeZaAdmina));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Transparent;
            this.btnZatvori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZatvori.BackgroundImage")));
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatvori.Location = new System.Drawing.Point(83, 185);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(77, 79);
            this.btnZatvori.TabIndex = 18;
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervacija.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezervacija.BackgroundImage")));
            this.btnRezervacija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervacija.Location = new System.Drawing.Point(74, 24);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(95, 93);
            this.btnRezervacija.TabIndex = 17;
            this.btnRezervacija.UseVisualStyleBackColor = false;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(91, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zatvori";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(71, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pregled i ispis rezervacije";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormaNeZaAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 358);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormaNeZaAdmina";
            this.Text = "Močilius - (Nema admin)";
            this.Load += new System.EventHandler(this.FormaNeZaAdmina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}