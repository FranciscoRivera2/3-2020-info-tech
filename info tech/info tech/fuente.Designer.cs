﻿
namespace info_tech
{
    partial class fuente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuente));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCertificación1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblCertificación2 = new System.Windows.Forms.Label();
            this.lblWatts1 = new System.Windows.Forms.Label();
            this.lblWatts2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picfuente1 = new System.Windows.Forms.PictureBox();
            this.picfuente2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfuente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfuente2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 162);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aerocool Cyclon",
            "Cooler Master MWE"});
            this.comboBox1.Location = new System.Drawing.Point(29, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCertificación1
            // 
            this.lblCertificación1.AutoSize = true;
            this.lblCertificación1.Location = new System.Drawing.Point(26, 534);
            this.lblCertificación1.Name = "lblCertificación1";
            this.lblCertificación1.Size = new System.Drawing.Size(68, 13);
            this.lblCertificación1.TabIndex = 2;
            this.lblCertificación1.Text = "Certificación:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Aerocool Cyclon",
            "Cooler Master MWE"});
            this.comboBox2.Location = new System.Drawing.Point(513, 418);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCertificación2
            // 
            this.lblCertificación2.AutoSize = true;
            this.lblCertificación2.Location = new System.Drawing.Point(510, 534);
            this.lblCertificación2.Name = "lblCertificación2";
            this.lblCertificación2.Size = new System.Drawing.Size(68, 13);
            this.lblCertificación2.TabIndex = 4;
            this.lblCertificación2.Text = "Certificación:";
            // 
            // lblWatts1
            // 
            this.lblWatts1.AutoSize = true;
            this.lblWatts1.Location = new System.Drawing.Point(26, 580);
            this.lblWatts1.Name = "lblWatts1";
            this.lblWatts1.Size = new System.Drawing.Size(38, 13);
            this.lblWatts1.TabIndex = 5;
            this.lblWatts1.Text = "Watts:";
            // 
            // lblWatts2
            // 
            this.lblWatts2.AutoSize = true;
            this.lblWatts2.Location = new System.Drawing.Point(510, 580);
            this.lblWatts2.Name = "lblWatts2";
            this.lblWatts2.Size = new System.Drawing.Size(38, 13);
            this.lblWatts2.TabIndex = 6;
            this.lblWatts2.Text = "Watts:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picfuente1
            // 
            this.picfuente1.Location = new System.Drawing.Point(29, 457);
            this.picfuente1.Name = "picfuente1";
            this.picfuente1.Size = new System.Drawing.Size(108, 50);
            this.picfuente1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfuente1.TabIndex = 9;
            this.picfuente1.TabStop = false;
            // 
            // picfuente2
            // 
            this.picfuente2.Location = new System.Drawing.Point(513, 457);
            this.picfuente2.Name = "picfuente2";
            this.picfuente2.Size = new System.Drawing.Size(100, 50);
            this.picfuente2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfuente2.TabIndex = 10;
            this.picfuente2.TabStop = false;
            // 
            // fuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.picfuente2);
            this.Controls.Add(this.picfuente1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWatts2);
            this.Controls.Add(this.lblWatts1);
            this.Controls.Add(this.lblCertificación2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCertificación1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "fuente";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.fuente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfuente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfuente2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCertificación1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblCertificación2;
        private System.Windows.Forms.Label lblWatts1;
        private System.Windows.Forms.Label lblWatts2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picfuente1;
        private System.Windows.Forms.PictureBox picfuente2;
    }
}