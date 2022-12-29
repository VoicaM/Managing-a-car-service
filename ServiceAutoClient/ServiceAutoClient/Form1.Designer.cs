
namespace ServiceAutoClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_autovehicule = new System.Windows.Forms.Button();
            this.button_reparatii = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_iesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Lemon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Auto";
            // 
            // button_autovehicule
            // 
            this.button_autovehicule.BackColor = System.Drawing.Color.Goldenrod;
            this.button_autovehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_autovehicule.Location = new System.Drawing.Point(231, 104);
            this.button_autovehicule.Name = "button_autovehicule";
            this.button_autovehicule.Size = new System.Drawing.Size(131, 45);
            this.button_autovehicule.TabIndex = 1;
            this.button_autovehicule.Text = "Autovehicule";
            this.button_autovehicule.UseVisualStyleBackColor = false;
            this.button_autovehicule.Click += new System.EventHandler(this.button_autovehicule_Click);
            // 
            // button_reparatii
            // 
            this.button_reparatii.BackColor = System.Drawing.Color.Goldenrod;
            this.button_reparatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reparatii.Location = new System.Drawing.Point(439, 104);
            this.button_reparatii.Name = "button_reparatii";
            this.button_reparatii.Size = new System.Drawing.Size(131, 45);
            this.button_reparatii.TabIndex = 2;
            this.button_reparatii.Text = "Reparații";
            this.button_reparatii.UseVisualStyleBackColor = false;
            this.button_reparatii.Click += new System.EventHandler(this.button_reparatii_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceAutoClient.Properties.Resources.imag1;
            this.pictureBox1.Location = new System.Drawing.Point(197, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iesire.Location = new System.Drawing.Point(672, 386);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(105, 42);
            this.button_iesire.TabIndex = 4;
            this.button_iesire.Text = "Ieșire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_reparatii);
            this.Controls.Add(this.button_autovehicule);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_autovehicule;
        private System.Windows.Forms.Button button_reparatii;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_iesire;
    }
}

