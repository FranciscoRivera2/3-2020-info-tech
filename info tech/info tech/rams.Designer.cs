
namespace info_tech
{
    partial class rams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rams));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFrecuencia1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFrecuencia2 = new System.Windows.Forms.Label();
            this.lblDDR1 = new System.Windows.Forms.Label();
            this.lblDDR2 = new System.Windows.Forms.Label();
            this.lblAlmacenamiento1 = new System.Windows.Forms.Label();
            this.lblAlmacenamiento2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picram1 = new System.Windows.Forms.PictureBox();
            this.picram2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picram2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 252);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "T-Force Vulcan Z",
            "Adata Value"});
            this.comboBox1.Location = new System.Drawing.Point(59, 454);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFrecuencia1
            // 
            this.lblFrecuencia1.AutoSize = true;
            this.lblFrecuencia1.Location = new System.Drawing.Point(56, 546);
            this.lblFrecuencia1.Name = "lblFrecuencia1";
            this.lblFrecuencia1.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia1.TabIndex = 3;
            this.lblFrecuencia1.Text = "Frecuencia:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "T-Force Vulcan Z",
            "Adata Value"});
            this.comboBox2.Location = new System.Drawing.Point(527, 454);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblFrecuencia2
            // 
            this.lblFrecuencia2.AutoSize = true;
            this.lblFrecuencia2.Location = new System.Drawing.Point(524, 546);
            this.lblFrecuencia2.Name = "lblFrecuencia2";
            this.lblFrecuencia2.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia2.TabIndex = 5;
            this.lblFrecuencia2.Text = "Frecuencia:";
            // 
            // lblDDR1
            // 
            this.lblDDR1.AutoSize = true;
            this.lblDDR1.Location = new System.Drawing.Point(56, 582);
            this.lblDDR1.Name = "lblDDR1";
            this.lblDDR1.Size = new System.Drawing.Size(34, 13);
            this.lblDDR1.TabIndex = 6;
            this.lblDDR1.Text = "DDR:";
            // 
            // lblDDR2
            // 
            this.lblDDR2.AutoSize = true;
            this.lblDDR2.Location = new System.Drawing.Point(524, 582);
            this.lblDDR2.Name = "lblDDR2";
            this.lblDDR2.Size = new System.Drawing.Size(34, 13);
            this.lblDDR2.TabIndex = 7;
            this.lblDDR2.Text = "DDR:";
            // 
            // lblAlmacenamiento1
            // 
            this.lblAlmacenamiento1.AutoSize = true;
            this.lblAlmacenamiento1.Location = new System.Drawing.Point(56, 620);
            this.lblAlmacenamiento1.Name = "lblAlmacenamiento1";
            this.lblAlmacenamiento1.Size = new System.Drawing.Size(88, 13);
            this.lblAlmacenamiento1.TabIndex = 8;
            this.lblAlmacenamiento1.Text = "Almacenamiento:";
            // 
            // lblAlmacenamiento2
            // 
            this.lblAlmacenamiento2.AutoSize = true;
            this.lblAlmacenamiento2.Location = new System.Drawing.Point(524, 620);
            this.lblAlmacenamiento2.Name = "lblAlmacenamiento2";
            this.lblAlmacenamiento2.Size = new System.Drawing.Size(88, 13);
            this.lblAlmacenamiento2.TabIndex = 9;
            this.lblAlmacenamiento2.Text = "Almacenamiento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-5, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picram1
            // 
            this.picram1.Location = new System.Drawing.Point(59, 481);
            this.picram1.Name = "picram1";
            this.picram1.Size = new System.Drawing.Size(100, 50);
            this.picram1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picram1.TabIndex = 11;
            this.picram1.TabStop = false;
            // 
            // picram2
            // 
            this.picram2.Location = new System.Drawing.Point(527, 481);
            this.picram2.Name = "picram2";
            this.picram2.Size = new System.Drawing.Size(100, 50);
            this.picram2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picram2.TabIndex = 12;
            this.picram2.TabStop = false;
            // 
            // rams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.picram2);
            this.Controls.Add(this.picram1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlmacenamiento2);
            this.Controls.Add(this.lblAlmacenamiento1);
            this.Controls.Add(this.lblDDR2);
            this.Controls.Add(this.lblDDR1);
            this.Controls.Add(this.lblFrecuencia2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblFrecuencia1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "rams";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.rams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picram2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFrecuencia1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFrecuencia2;
        private System.Windows.Forms.Label lblDDR1;
        private System.Windows.Forms.Label lblDDR2;
        private System.Windows.Forms.Label lblAlmacenamiento1;
        private System.Windows.Forms.Label lblAlmacenamiento2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picram1;
        private System.Windows.Forms.PictureBox picram2;
    }
}