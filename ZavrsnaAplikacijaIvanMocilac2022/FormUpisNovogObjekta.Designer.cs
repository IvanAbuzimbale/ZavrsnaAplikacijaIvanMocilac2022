
namespace ZavrsnaAplikacijaIvanMocilac2022
{
    partial class FormUpisNovogObjekta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpisNovogObjekta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeObjekta = new System.Windows.Forms.TextBox();
            this.txtVlasnikObjekta = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime objekta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik objekta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena po danu (u €):";
            // 
            // txtImeObjekta
            // 
            this.txtImeObjekta.Location = new System.Drawing.Point(123, 10);
            this.txtImeObjekta.Name = "txtImeObjekta";
            this.txtImeObjekta.Size = new System.Drawing.Size(100, 20);
            this.txtImeObjekta.TabIndex = 3;
            // 
            // txtVlasnikObjekta
            // 
            this.txtVlasnikObjekta.Location = new System.Drawing.Point(123, 44);
            this.txtVlasnikObjekta.Name = "txtVlasnikObjekta";
            this.txtVlasnikObjekta.Size = new System.Drawing.Size(100, 20);
            this.txtVlasnikObjekta.TabIndex = 4;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(123, 79);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 5;
            // 
            // btnUpisi
            // 
            this.btnUpisi.BackColor = System.Drawing.Color.Transparent;
            this.btnUpisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpisi.BackgroundImage")));
            this.btnUpisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpisi.Location = new System.Drawing.Point(99, 159);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(72, 85);
            this.btnUpisi.TabIndex = 6;
            this.btnUpisi.UseVisualStyleBackColor = false;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // FormUpisNovogObjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 256);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtVlasnikObjekta);
            this.Controls.Add(this.txtImeObjekta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpisNovogObjekta";
            this.Text = "Upis novog objekta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeObjekta;
        private System.Windows.Forms.TextBox txtVlasnikObjekta;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnUpisi;
    }
}