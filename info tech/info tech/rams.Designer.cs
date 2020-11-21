
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "T-Force Vulcan Z",
            "Adata Value"});
            this.comboBox1.Location = new System.Drawing.Point(132, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblFrecuencia1
            // 
            this.lblFrecuencia1.AutoSize = true;
            this.lblFrecuencia1.Location = new System.Drawing.Point(132, 312);
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
            this.comboBox2.Location = new System.Drawing.Point(629, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lblFrecuencia2
            // 
            this.lblFrecuencia2.AutoSize = true;
            this.lblFrecuencia2.Location = new System.Drawing.Point(626, 312);
            this.lblFrecuencia2.Name = "lblFrecuencia2";
            this.lblFrecuencia2.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia2.TabIndex = 5;
            this.lblFrecuencia2.Text = "Frecuencia:";
            // 
            // lblDDR1
            // 
            this.lblDDR1.AutoSize = true;
            this.lblDDR1.Location = new System.Drawing.Point(129, 348);
            this.lblDDR1.Name = "lblDDR1";
            this.lblDDR1.Size = new System.Drawing.Size(34, 13);
            this.lblDDR1.TabIndex = 6;
            this.lblDDR1.Text = "DDR:";
            // 
            // lblDDR2
            // 
            this.lblDDR2.AutoSize = true;
            this.lblDDR2.Location = new System.Drawing.Point(626, 348);
            this.lblDDR2.Name = "lblDDR2";
            this.lblDDR2.Size = new System.Drawing.Size(34, 13);
            this.lblDDR2.TabIndex = 7;
            this.lblDDR2.Text = "DDR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // rams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}