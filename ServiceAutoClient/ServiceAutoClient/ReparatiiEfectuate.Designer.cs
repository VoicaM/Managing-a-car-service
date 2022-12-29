
namespace ServiceAutoClient
{
    partial class ReparatiiEfectuate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nr_crt = new System.Windows.Forms.TextBox();
            this.textBox_durata_efectuare = new System.Windows.Forms.TextBox();
            this.textBox_data_finalizare = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_adaugare = new System.Windows.Forms.Button();
            this.button_editare = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_autovehicule = new System.Windows.Forms.Button();
            this.button_iesire = new System.Windows.Forms.Button();
            this.textBox_cod_reparatie = new System.Windows.Forms.TextBox();
            this.button_tipuri_reparatii = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_cod_auto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr_crt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod_reparatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cod_auto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durată efectuare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dată finalizare";
            // 
            // textBox_nr_crt
            // 
            this.textBox_nr_crt.Location = new System.Drawing.Point(152, 56);
            this.textBox_nr_crt.Name = "textBox_nr_crt";
            this.textBox_nr_crt.ReadOnly = true;
            this.textBox_nr_crt.Size = new System.Drawing.Size(133, 22);
            this.textBox_nr_crt.TabIndex = 6;
            // 
            // textBox_durata_efectuare
            // 
            this.textBox_durata_efectuare.Location = new System.Drawing.Point(152, 171);
            this.textBox_durata_efectuare.Name = "textBox_durata_efectuare";
            this.textBox_durata_efectuare.Size = new System.Drawing.Size(133, 22);
            this.textBox_durata_efectuare.TabIndex = 7;
            // 
            // textBox_data_finalizare
            // 
            this.textBox_data_finalizare.Location = new System.Drawing.Point(152, 208);
            this.textBox_data_finalizare.Name = "textBox_data_finalizare";
            this.textBox_data_finalizare.Size = new System.Drawing.Size(133, 22);
            this.textBox_data_finalizare.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(478, 174);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button_adaugare
            // 
            this.button_adaugare.BackColor = System.Drawing.Color.MediumPurple;
            this.button_adaugare.Location = new System.Drawing.Point(28, 265);
            this.button_adaugare.Name = "button_adaugare";
            this.button_adaugare.Size = new System.Drawing.Size(112, 42);
            this.button_adaugare.TabIndex = 12;
            this.button_adaugare.Text = "Adaugă";
            this.button_adaugare.UseVisualStyleBackColor = false;
            this.button_adaugare.Click += new System.EventHandler(this.button_adaugare_Click);
            // 
            // button_editare
            // 
            this.button_editare.BackColor = System.Drawing.Color.MediumPurple;
            this.button_editare.Location = new System.Drawing.Point(28, 329);
            this.button_editare.Name = "button_editare";
            this.button_editare.Size = new System.Drawing.Size(112, 42);
            this.button_editare.TabIndex = 13;
            this.button_editare.Text = "Editează";
            this.button_editare.UseVisualStyleBackColor = false;
            this.button_editare.Click += new System.EventHandler(this.button_editare_Click);
            // 
            // button_stergere
            // 
            this.button_stergere.BackColor = System.Drawing.Color.MediumPurple;
            this.button_stergere.Location = new System.Drawing.Point(28, 394);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(112, 42);
            this.button_stergere.TabIndex = 14;
            this.button_stergere.Text = "Șterge";
            this.button_stergere.UseVisualStyleBackColor = false;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_refresh.Location = new System.Drawing.Point(556, 395);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(108, 43);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_autovehicule
            // 
            this.button_autovehicule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_autovehicule.Location = new System.Drawing.Point(665, 246);
            this.button_autovehicule.Name = "button_autovehicule";
            this.button_autovehicule.Size = new System.Drawing.Size(123, 47);
            this.button_autovehicule.TabIndex = 17;
            this.button_autovehicule.Text = "Autovehicule";
            this.button_autovehicule.UseVisualStyleBackColor = false;
            this.button_autovehicule.Click += new System.EventHandler(this.button_autovehicule_Click);
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_iesire.Location = new System.Drawing.Point(680, 395);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(108, 43);
            this.button_iesire.TabIndex = 19;
            this.button_iesire.Text = "Ieșire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // textBox_cod_reparatie
            // 
            this.textBox_cod_reparatie.Location = new System.Drawing.Point(152, 94);
            this.textBox_cod_reparatie.Name = "textBox_cod_reparatie";
            this.textBox_cod_reparatie.ReadOnly = true;
            this.textBox_cod_reparatie.Size = new System.Drawing.Size(133, 22);
            this.textBox_cod_reparatie.TabIndex = 20;
            // 
            // button_tipuri_reparatii
            // 
            this.button_tipuri_reparatii.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_tipuri_reparatii.Location = new System.Drawing.Point(525, 246);
            this.button_tipuri_reparatii.Name = "button_tipuri_reparatii";
            this.button_tipuri_reparatii.Size = new System.Drawing.Size(123, 47);
            this.button_tipuri_reparatii.TabIndex = 16;
            this.button_tipuri_reparatii.Text = "Tipuri reparații";
            this.button_tipuri_reparatii.UseVisualStyleBackColor = false;
            this.button_tipuri_reparatii.Click += new System.EventHandler(this.button_tipuri_reparatii_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceAutoClient.Properties.Resources.im6;
            this.pictureBox1.Location = new System.Drawing.Point(152, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_cod_auto
            // 
            this.textBox_cod_auto.Location = new System.Drawing.Point(152, 132);
            this.textBox_cod_auto.Name = "textBox_cod_auto";
            this.textBox_cod_auto.ReadOnly = true;
            this.textBox_cod_auto.Size = new System.Drawing.Size(133, 22);
            this.textBox_cod_auto.TabIndex = 21;
            // 
            // ReparatiiEfectuate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_cod_auto);
            this.Controls.Add(this.textBox_cod_reparatie);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_autovehicule);
            this.Controls.Add(this.button_tipuri_reparatii);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.button_editare);
            this.Controls.Add(this.button_adaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_data_finalizare);
            this.Controls.Add(this.textBox_durata_efectuare);
            this.Controls.Add(this.textBox_nr_crt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReparatiiEfectuate";
            this.Text = "ReparatiiEfectuate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nr_crt;
        private System.Windows.Forms.TextBox textBox_durata_efectuare;
        private System.Windows.Forms.TextBox textBox_data_finalizare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_adaugare;
        private System.Windows.Forms.Button button_editare;
        private System.Windows.Forms.Button button_stergere;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_autovehicule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_iesire;
        private System.Windows.Forms.TextBox textBox_cod_reparatie;
        private System.Windows.Forms.Button button_tipuri_reparatii;
        private System.Windows.Forms.TextBox textBox_cod_auto;
    }
}