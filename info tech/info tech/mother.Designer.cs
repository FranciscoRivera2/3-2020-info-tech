
namespace info_tech
{
    partial class mother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mother));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblmodulos1 = new System.Windows.Forms.Label();
            this.lblmodulos2 = new System.Windows.Forms.Label();
            this.lblpuertos1 = new System.Windows.Forms.Label();
            this.lblpuertos2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1312, 320);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gigabyte Z390 M",
            "ASUS PRIME B460M-A"});
            this.comboBox1.Location = new System.Drawing.Point(22, 472);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Gigabyte Z390 M",
            "ASUS PRIME B460M-A"});
            this.comboBox2.Location = new System.Drawing.Point(975, 472);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblmodulos1
            // 
            this.lblmodulos1.AutoSize = true;
            this.lblmodulos1.Location = new System.Drawing.Point(18, 532);
            this.lblmodulos1.Name = "lblmodulos1";
            this.lblmodulos1.Size = new System.Drawing.Size(73, 20);
            this.lblmodulos1.TabIndex = 3;
            this.lblmodulos1.Text = "modulos:";
            this.lblmodulos1.Click += new System.EventHandler(this.lblmodulos1_Click);
            // 
            // lblmodulos2
            // 
            this.lblmodulos2.AutoSize = true;
            this.lblmodulos2.Location = new System.Drawing.Point(971, 532);
            this.lblmodulos2.Name = "lblmodulos2";
            this.lblmodulos2.Size = new System.Drawing.Size(73, 20);
            this.lblmodulos2.TabIndex = 4;
            this.lblmodulos2.Text = "modulos:";
            // 
            // lblpuertos1
            // 
            this.lblpuertos1.AutoSize = true;
            this.lblpuertos1.Location = new System.Drawing.Point(18, 584);
            this.lblpuertos1.Name = "lblpuertos1";
            this.lblpuertos1.Size = new System.Drawing.Size(67, 20);
            this.lblpuertos1.TabIndex = 5;
            this.lblpuertos1.Text = "puertos:";
            // 
            // lblpuertos2
            // 
            this.lblpuertos2.AutoSize = true;
            this.lblpuertos2.Location = new System.Drawing.Point(977, 584);
            this.lblpuertos2.Name = "lblpuertos2";
            this.lblpuertos2.Size = new System.Drawing.Size(67, 20);
            this.lblpuertos2.TabIndex = 6;
            this.lblpuertos2.Text = "puertos:";
            // 
            // mother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 849);
            this.Controls.Add(this.lblpuertos2);
            this.Controls.Add(this.lblpuertos1);
            this.Controls.Add(this.lblmodulos2);
            this.Controls.Add(this.lblmodulos1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mother";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.mother_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblmodulos1;
        private System.Windows.Forms.Label lblmodulos2;
        private System.Windows.Forms.Label lblpuertos1;
        private System.Windows.Forms.Label lblpuertos2;
    }
}