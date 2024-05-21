namespace LukaIvanic
{
    partial class Form1
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
            this.listPredmeti = new System.Windows.Forms.ComboBox();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtPisanje = new System.Windows.Forms.RichTextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPredmeti
            // 
            this.listPredmeti.FormattingEnabled = true;
            this.listPredmeti.Items.AddRange(new object[] {
            "Hrvatski jezik",
            "Matematika"});
            this.listPredmeti.Location = new System.Drawing.Point(12, 12);
            this.listPredmeti.Name = "listPredmeti";
            this.listPredmeti.Size = new System.Drawing.Size(533, 28);
            this.listPredmeti.TabIndex = 0;
            this.listPredmeti.Text = "predmeti";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(572, 120);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(71, 26);
            this.txtOcjena.TabIndex = 1;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(664, 120);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(101, 26);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(572, 237);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(193, 76);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(572, 347);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(193, 76);
            this.btnIspisi.TabIndex = 4;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // txtPisanje
            // 
            this.txtPisanje.Location = new System.Drawing.Point(12, 113);
            this.txtPisanje.Name = "txtPisanje";
            this.txtPisanje.Size = new System.Drawing.Size(533, 310);
            this.txtPisanje.TabIndex = 5;
            this.txtPisanje.Text = "";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(572, 12);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(193, 80);
            this.btnUcitaj.TabIndex = 6;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.txtPisanje);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.listPredmeti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listPredmeti;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.RichTextBox txtPisanje;
        private System.Windows.Forms.Button btnUcitaj;
    }
}

