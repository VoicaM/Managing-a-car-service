
namespace ServiceAutoClient
{
    partial class Reparatii
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_editare = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_continuare = new System.Windows.Forms.Button();
            this.comboBox_reparatii = new System.Windows.Forms.ComboBox();
            this.textBox_cod_reparatie = new System.Windows.Forms.TextBox();
            this.textBox_denumire_reparatie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_adăugare = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Denumire reparație";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selectează tipul reparației";
            // 
            // button_editare
            // 
            this.button_editare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_editare.Location = new System.Drawing.Point(19, 259);
            this.button_editare.Name = "button_editare";
            this.button_editare.Size = new System.Drawing.Size(113, 32);
            this.button_editare.TabIndex = 22;
            this.button_editare.Text = "Editează";
            this.button_editare.UseVisualStyleBackColor = false;
            this.button_editare.Click += new System.EventHandler(this.button_editare_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_refresh.Location = new System.Drawing.Point(19, 379);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(113, 32);
            this.button_refresh.TabIndex = 23;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_continuare
            // 
            this.button_continuare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_continuare.Location = new System.Drawing.Point(700, 410);
            this.button_continuare.Name = "button_continuare";
            this.button_continuare.Size = new System.Drawing.Size(88, 28);
            this.button_continuare.TabIndex = 24;
            this.button_continuare.Text = "Continuă";
            this.button_continuare.UseVisualStyleBackColor = false;
            this.button_continuare.Click += new System.EventHandler(this.button_continuare_Click);
            // 
            // comboBox_reparatii
            // 
            this.comboBox_reparatii.FormattingEnabled = true;
            this.comboBox_reparatii.Location = new System.Drawing.Point(200, 126);
            this.comboBox_reparatii.Name = "comboBox_reparatii";
            this.comboBox_reparatii.Size = new System.Drawing.Size(496, 24);
            this.comboBox_reparatii.TabIndex = 25;
            this.comboBox_reparatii.SelectedIndexChanged += new System.EventHandler(this.comboBox_reparatii_SelectedIndexChanged);
            // 
            // textBox_cod_reparatie
            // 
            this.textBox_cod_reparatie.Location = new System.Drawing.Point(200, 50);
            this.textBox_cod_reparatie.Name = "textBox_cod_reparatie";
            this.textBox_cod_reparatie.ReadOnly = true;
            this.textBox_cod_reparatie.Size = new System.Drawing.Size(142, 22);
            this.textBox_cod_reparatie.TabIndex = 26;
            // 
            // textBox_denumire_reparatie
            // 
            this.textBox_denumire_reparatie.Location = new System.Drawing.Point(200, 88);
            this.textBox_denumire_reparatie.Name = "textBox_denumire_reparatie";
            this.textBox_denumire_reparatie.Size = new System.Drawing.Size(496, 22);
            this.textBox_denumire_reparatie.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cod_reparație";
            // 
            // button_adăugare
            // 
            this.button_adăugare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_adăugare.Location = new System.Drawing.Point(19, 199);
            this.button_adăugare.Name = "button_adăugare";
            this.button_adăugare.Size = new System.Drawing.Size(113, 32);
            this.button_adăugare.TabIndex = 29;
            this.button_adăugare.Text = "Adaugă";
            this.button_adăugare.UseVisualStyleBackColor = false;
            this.button_adăugare.Click += new System.EventHandler(this.button_adăugare_Click);
            // 
            // button_stergere
            // 
            this.button_stergere.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_stergere.Location = new System.Drawing.Point(19, 319);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(113, 32);
            this.button_stergere.TabIndex = 31;
            this.button_stergere.Text = "Șterge";
            this.button_stergere.UseVisualStyleBackColor = false;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
            // 
            // Reparatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.button_adăugare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_denumire_reparatie);
            this.Controls.Add(this.textBox_cod_reparatie);
            this.Controls.Add(this.comboBox_reparatii);
            this.Controls.Add(this.button_continuare);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_editare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Reparatii";
            this.Text = "Reparatii";
            this.Load += new System.EventHandler(this.Reparatii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_editare;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_continuare;
        private System.Windows.Forms.ComboBox comboBox_reparatii;
        private System.Windows.Forms.TextBox textBox_cod_reparatie;
        private System.Windows.Forms.TextBox textBox_denumire_reparatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_adăugare;
        private System.Windows.Forms.Button button_stergere;
    }
}