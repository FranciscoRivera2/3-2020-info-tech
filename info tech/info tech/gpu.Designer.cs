
namespace info_tech
{
    partial class gpu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gpu));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblGama1 = new System.Windows.Forms.Label();
            this.lblGama2 = new System.Windows.Forms.Label();
            this.lblVram1 = new System.Windows.Forms.Label();
            this.lblVram2 = new System.Windows.Forms.Label();
            this.lblDDR1 = new System.Windows.Forms.Label();
            this.lblDDR2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2254, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nvidea 1660 Super",
            "Radeon 590"});
            this.comboBox1.Location = new System.Drawing.Point(130, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblGama1
            // 
            this.lblGama1.AutoSize = true;
            this.lblGama1.Location = new System.Drawing.Point(166, 393);
            this.lblGama1.Name = "lblGama1";
            this.lblGama1.Size = new System.Drawing.Size(38, 13);
            this.lblGama1.TabIndex = 3;
            this.lblGama1.Text = "Gama:";
            // 
            // lblGama2
            // 
            this.lblGama2.AutoSize = true;
            this.lblGama2.Location = new System.Drawing.Point(725, 393);
            this.lblGama2.Name = "lblGama2";
            this.lblGama2.Size = new System.Drawing.Size(38, 13);
            this.lblGama2.TabIndex = 4;
            this.lblGama2.Text = "Gama:";
            // 
            // lblVram1
            // 
            this.lblVram1.AutoSize = true;
            this.lblVram1.Location = new System.Drawing.Point(166, 451);
            this.lblVram1.Name = "lblVram1";
            this.lblVram1.Size = new System.Drawing.Size(34, 13);
            this.lblVram1.TabIndex = 5;
            this.lblVram1.Text = "Vram:";
            // 
            // lblVram2
            // 
            this.lblVram2.AutoSize = true;
            this.lblVram2.Location = new System.Drawing.Point(725, 451);
            this.lblVram2.Name = "lblVram2";
            this.lblVram2.Size = new System.Drawing.Size(34, 13);
            this.lblVram2.TabIndex = 6;
            this.lblVram2.Text = "Vram:";
            // 
            // lblDDR1
            // 
            this.lblDDR1.AutoSize = true;
            this.lblDDR1.Location = new System.Drawing.Point(166, 505);
            this.lblDDR1.Name = "lblDDR1";
            this.lblDDR1.Size = new System.Drawing.Size(34, 13);
            this.lblDDR1.TabIndex = 7;
            this.lblDDR1.Text = "DDR:";
            // 
            // lblDDR2
            // 
            this.lblDDR2.AutoSize = true;
            this.lblDDR2.Location = new System.Drawing.Point(725, 505);
            this.lblDDR2.Name = "lblDDR2";
            this.lblDDR2.Size = new System.Drawing.Size(34, 13);
            this.lblDDR2.TabIndex = 8;
            this.lblDDR2.Text = "DDR:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1034, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nvidea 1660 Super",
            "Radeon 590"});
            this.comboBox2.Location = new System.Drawing.Point(679, 271);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // gpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 732);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDDR2);
            this.Controls.Add(this.lblDDR1);
            this.Controls.Add(this.lblVram2);
            this.Controls.Add(this.lblVram1);
            this.Controls.Add(this.lblGama2);
            this.Controls.Add(this.lblGama1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "gpu";
            this.Text = "gpu";
            this.Load += new System.EventHandler(this.gpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblGama1;
        private System.Windows.Forms.Label lblGama2;
        private System.Windows.Forms.Label lblVram1;
        private System.Windows.Forms.Label lblVram2;
        private System.Windows.Forms.Label lblDDR1;
        private System.Windows.Forms.Label lblDDR2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}