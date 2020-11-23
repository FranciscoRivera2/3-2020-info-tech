
namespace info_tech
{
    partial class procesadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procesadores));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblGeneración1 = new System.Windows.Forms.Label();
            this.lblGeneración2 = new System.Windows.Forms.Label();
            this.lblHilos1 = new System.Windows.Forms.Label();
            this.lblFrecuenciaTurbo2 = new System.Windows.Forms.Label();
            this.lblFrecuenciaTurbo1 = new System.Windows.Forms.Label();
            this.lblHilos2 = new System.Windows.Forms.Label();
            this.lblNucleos1 = new System.Windows.Forms.Label();
            this.lblNucleos2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1876, 169);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "intel i3",
            "Ryzen R3"});
            this.comboBox1.Location = new System.Drawing.Point(110, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "intel i3",
            "Ryzen R3"});
            this.comboBox2.Location = new System.Drawing.Point(753, 349);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // lblGeneración1
            // 
            this.lblGeneración1.AutoSize = true;
            this.lblGeneración1.Location = new System.Drawing.Point(141, 446);
            this.lblGeneración1.Name = "lblGeneración1";
            this.lblGeneración1.Size = new System.Drawing.Size(65, 13);
            this.lblGeneración1.TabIndex = 12;
            this.lblGeneración1.Text = "Generación:";
            // 
            // lblGeneración2
            // 
            this.lblGeneración2.AutoSize = true;
            this.lblGeneración2.Location = new System.Drawing.Point(791, 446);
            this.lblGeneración2.Name = "lblGeneración2";
            this.lblGeneración2.Size = new System.Drawing.Size(65, 13);
            this.lblGeneración2.TabIndex = 13;
            this.lblGeneración2.Text = "Generación:";
            // 
            // lblHilos1
            // 
            this.lblHilos1.AutoSize = true;
            this.lblHilos1.Location = new System.Drawing.Point(141, 520);
            this.lblHilos1.Name = "lblHilos1";
            this.lblHilos1.Size = new System.Drawing.Size(33, 13);
            this.lblHilos1.TabIndex = 14;
            this.lblHilos1.Text = "Hilos:";
            // 
            // lblFrecuenciaTurbo2
            // 
            this.lblFrecuenciaTurbo2.AutoSize = true;
            this.lblFrecuenciaTurbo2.Location = new System.Drawing.Point(791, 484);
            this.lblFrecuenciaTurbo2.Name = "lblFrecuenciaTurbo2";
            this.lblFrecuenciaTurbo2.Size = new System.Drawing.Size(94, 13);
            this.lblFrecuenciaTurbo2.TabIndex = 15;
            this.lblFrecuenciaTurbo2.Text = "Frecuencia Turbo:";
            // 
            // lblFrecuenciaTurbo1
            // 
            this.lblFrecuenciaTurbo1.AutoSize = true;
            this.lblFrecuenciaTurbo1.Location = new System.Drawing.Point(141, 484);
            this.lblFrecuenciaTurbo1.Name = "lblFrecuenciaTurbo1";
            this.lblFrecuenciaTurbo1.Size = new System.Drawing.Size(94, 13);
            this.lblFrecuenciaTurbo1.TabIndex = 16;
            this.lblFrecuenciaTurbo1.Text = "Frecuencia Turbo:";
            // 
            // lblHilos2
            // 
            this.lblHilos2.AutoSize = true;
            this.lblHilos2.Location = new System.Drawing.Point(791, 520);
            this.lblHilos2.Name = "lblHilos2";
            this.lblHilos2.Size = new System.Drawing.Size(33, 13);
            this.lblHilos2.TabIndex = 17;
            this.lblHilos2.Text = "Hilos:";
            // 
            // lblNucleos1
            // 
            this.lblNucleos1.AutoSize = true;
            this.lblNucleos1.Location = new System.Drawing.Point(141, 558);
            this.lblNucleos1.Name = "lblNucleos1";
            this.lblNucleos1.Size = new System.Drawing.Size(49, 13);
            this.lblNucleos1.TabIndex = 18;
            this.lblNucleos1.Text = "Nucleos:";
            // 
            // lblNucleos2
            // 
            this.lblNucleos2.AutoSize = true;
            this.lblNucleos2.Location = new System.Drawing.Point(791, 558);
            this.lblNucleos2.Name = "lblNucleos2";
            this.lblNucleos2.Size = new System.Drawing.Size(49, 13);
            this.lblNucleos2.TabIndex = 19;
            this.lblNucleos2.Text = "Nucleos:";
            // 
            // procesadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1037);
            this.Controls.Add(this.lblNucleos2);
            this.Controls.Add(this.lblNucleos1);
            this.Controls.Add(this.lblHilos2);
            this.Controls.Add(this.lblFrecuenciaTurbo1);
            this.Controls.Add(this.lblFrecuenciaTurbo2);
            this.Controls.Add(this.lblHilos1);
            this.Controls.Add(this.lblGeneración2);
            this.Controls.Add(this.lblGeneración1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "procesadores";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.procesadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblGeneración1;
        private System.Windows.Forms.Label lblGeneración2;
        private System.Windows.Forms.Label lblHilos1;
        private System.Windows.Forms.Label lblFrecuenciaTurbo2;
        private System.Windows.Forms.Label lblFrecuenciaTurbo1;
        private System.Windows.Forms.Label lblHilos2;
        private System.Windows.Forms.Label lblNucleos1;
        private System.Windows.Forms.Label lblNucleos2;
    }
}