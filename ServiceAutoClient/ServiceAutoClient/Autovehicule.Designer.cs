
namespace ServiceAutoClient
{
    partial class Autovehicule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_adaugare = new System.Windows.Forms.Button();
            this.button_editare = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_cod_auto = new System.Windows.Forms.TextBox();
            this.textBox_marca = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_an_fabricatie = new System.Windows.Forms.TextBox();
            this.button_iesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod_auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "An fabricație";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 254);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button_adaugare
            // 
            this.button_adaugare.BackColor = System.Drawing.Color.Peru;
            this.button_adaugare.Location = new System.Drawing.Point(295, 321);
            this.button_adaugare.Name = "button_adaugare";
            this.button_adaugare.Size = new System.Drawing.Size(97, 34);
            this.button_adaugare.TabIndex = 10;
            this.button_adaugare.Text = "Adaugă";
            this.button_adaugare.UseVisualStyleBackColor = false;
            this.button_adaugare.Click += new System.EventHandler(this.button_adaugare_Click);
            // 
            // button_editare
            // 
            this.button_editare.BackColor = System.Drawing.Color.Peru;
            this.button_editare.Location = new System.Drawing.Point(407, 321);
            this.button_editare.Name = "button_editare";
            this.button_editare.Size = new System.Drawing.Size(97, 34);
            this.button_editare.TabIndex = 11;
            this.button_editare.Text = "Editează";
            this.button_editare.UseVisualStyleBackColor = false;
            this.button_editare.Click += new System.EventHandler(this.button_editare_Click);
            // 
            // button_stergere
            // 
            this.button_stergere.BackColor = System.Drawing.Color.Peru;
            this.button_stergere.Location = new System.Drawing.Point(519, 321);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(97, 34);
            this.button_stergere.TabIndex = 12;
            this.button_stergere.Text = "Șterge";
            this.button_stergere.UseVisualStyleBackColor = false;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_refresh.Location = new System.Drawing.Point(691, 321);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(97, 34);
            this.button_refresh.TabIndex = 13;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceAutoClient.Properties.Resources.im5;
            this.pictureBox1.Location = new System.Drawing.Point(16, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_cod_auto
            // 
            this.textBox_cod_auto.Location = new System.Drawing.Point(125, 51);
            this.textBox_cod_auto.Name = "textBox_cod_auto";
            this.textBox_cod_auto.ReadOnly = true;
            this.textBox_cod_auto.Size = new System.Drawing.Size(148, 22);
            this.textBox_cod_auto.TabIndex = 15;
            // 
            // textBox_marca
            // 
            this.textBox_marca.Location = new System.Drawing.Point(125, 86);
            this.textBox_marca.Name = "textBox_marca";
            this.textBox_marca.Size = new System.Drawing.Size(148, 22);
            this.textBox_marca.TabIndex = 16;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(125, 121);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(148, 22);
            this.textBox_model.TabIndex = 17;
            // 
            // textBox_an_fabricatie
            // 
            this.textBox_an_fabricatie.Location = new System.Drawing.Point(125, 156);
            this.textBox_an_fabricatie.Name = "textBox_an_fabricatie";
            this.textBox_an_fabricatie.Size = new System.Drawing.Size(148, 22);
            this.textBox_an_fabricatie.TabIndex = 18;
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_iesire.Location = new System.Drawing.Point(691, 401);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(97, 27);
            this.button_iesire.TabIndex = 19;
            this.button_iesire.Text = "Ieșire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // Autovehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.textBox_an_fabricatie);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_marca);
            this.Controls.Add(this.textBox_cod_auto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.button_editare);
            this.Controls.Add(this.button_adaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autovehicule";
            this.Text = "Autovehicule";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_adaugare;
        private System.Windows.Forms.Button button_editare;
        private System.Windows.Forms.Button button_stergere;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_cod_auto;
        private System.Windows.Forms.TextBox textBox_marca;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_an_fabricatie;
        private System.Windows.Forms.Button button_iesire;
    }
}