
namespace info_tech
{
    partial class gabinete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabinete));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPuertos1 = new System.Windows.Forms.Label();
            this.lblPuertos2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picgabinete1 = new System.Windows.Forms.PictureBox();
            this.picgabinete2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picgabinete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgabinete2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 189);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sentey Z20 Lite",
            "Thermaltake V200"});
            this.comboBox1.Location = new System.Drawing.Point(35, 422);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sentey Z20 Lite",
            "Thermaltake V200"});
            this.comboBox2.Location = new System.Drawing.Point(447, 422);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblPuertos1
            // 
            this.lblPuertos1.AutoSize = true;
            this.lblPuertos1.Location = new System.Drawing.Point(32, 559);
            this.lblPuertos1.Name = "lblPuertos1";
            this.lblPuertos1.Size = new System.Drawing.Size(68, 20);
            this.lblPuertos1.TabIndex = 3;
            this.lblPuertos1.Text = "Puertos:";
            // 
            // lblPuertos2
            // 
            this.lblPuertos2.AutoSize = true;
            this.lblPuertos2.Location = new System.Drawing.Point(443, 559);
            this.lblPuertos2.Name = "lblPuertos2";
            this.lblPuertos2.Size = new System.Drawing.Size(68, 20);
            this.lblPuertos2.TabIndex = 4;
            this.lblPuertos2.Text = "Puertos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picgabinete1
            // 
            this.picgabinete1.Location = new System.Drawing.Point(35, 469);
            this.picgabinete1.Name = "picgabinete1";
            this.picgabinete1.Size = new System.Drawing.Size(100, 50);
            this.picgabinete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgabinete1.TabIndex = 9;
            this.picgabinete1.TabStop = false;
            // 
            // picgabinete2
            // 
            this.picgabinete2.Location = new System.Drawing.Point(447, 469);
            this.picgabinete2.Name = "picgabinete2";
            this.picgabinete2.Size = new System.Drawing.Size(100, 50);
            this.picgabinete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgabinete2.TabIndex = 10;
            this.picgabinete2.TabStop = false;
            // 
            // gabinete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.picgabinete2);
            this.Controls.Add(this.picgabinete1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPuertos2);
            this.Controls.Add(this.lblPuertos1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gabinete";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.gabinete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picgabinete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgabinete2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblPuertos1;
        private System.Windows.Forms.Label lblPuertos2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picgabinete1;
        private System.Windows.Forms.PictureBox picgabinete2;
    }
}