
namespace info_tech
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPanel1 = new System.Windows.Forms.Label();
            this.lblPanel2 = new System.Windows.Forms.Label();
            this.lblResolución1 = new System.Windows.Forms.Label();
            this.lblResolución2 = new System.Windows.Forms.Label();
            this.lblHercios1 = new System.Windows.Forms.Label();
            this.lblHercios2 = new System.Windows.Forms.Label();
            this.lblPulgadas1 = new System.Windows.Forms.Label();
            this.lblPulgadas2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1168, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LG 24gl600f",
            "Viewsonic VX3276-4K-MHD"});
            this.comboBox1.Location = new System.Drawing.Point(75, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LG 24gl600f",
            "Viewsonic VX3276-4K-MHD"});
            this.comboBox2.Location = new System.Drawing.Point(340, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // lblPanel1
            // 
            this.lblPanel1.AutoSize = true;
            this.lblPanel1.Location = new System.Drawing.Point(58, 284);
            this.lblPanel1.Name = "lblPanel1";
            this.lblPanel1.Size = new System.Drawing.Size(37, 13);
            this.lblPanel1.TabIndex = 3;
            this.lblPanel1.Text = "Panel:";
            // 
            // lblPanel2
            // 
            this.lblPanel2.AutoSize = true;
            this.lblPanel2.Location = new System.Drawing.Point(378, 284);
            this.lblPanel2.Name = "lblPanel2";
            this.lblPanel2.Size = new System.Drawing.Size(37, 13);
            this.lblPanel2.TabIndex = 4;
            this.lblPanel2.Text = "Panel:";
            // 
            // lblResolución1
            // 
            this.lblResolución1.AutoSize = true;
            this.lblResolución1.Location = new System.Drawing.Point(49, 322);
            this.lblResolución1.Name = "lblResolución1";
            this.lblResolución1.Size = new System.Drawing.Size(63, 13);
            this.lblResolución1.TabIndex = 5;
            this.lblResolución1.Text = "Resolución:";
            this.lblResolución1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblResolución2
            // 
            this.lblResolución2.AutoSize = true;
            this.lblResolución2.Location = new System.Drawing.Point(378, 333);
            this.lblResolución2.Name = "lblResolución2";
            this.lblResolución2.Size = new System.Drawing.Size(63, 13);
            this.lblResolución2.TabIndex = 6;
            this.lblResolución2.Text = "Resolución:";
            // 
            // lblHercios1
            // 
            this.lblHercios1.AutoSize = true;
            this.lblHercios1.Location = new System.Drawing.Point(49, 360);
            this.lblHercios1.Name = "lblHercios1";
            this.lblHercios1.Size = new System.Drawing.Size(46, 13);
            this.lblHercios1.TabIndex = 7;
            this.lblHercios1.Text = "Hercios:";
            // 
            // lblHercios2
            // 
            this.lblHercios2.AutoSize = true;
            this.lblHercios2.Location = new System.Drawing.Point(378, 373);
            this.lblHercios2.Name = "lblHercios2";
            this.lblHercios2.Size = new System.Drawing.Size(46, 13);
            this.lblHercios2.TabIndex = 8;
            this.lblHercios2.Text = "Hercios:";
            // 
            // lblPulgadas1
            // 
            this.lblPulgadas1.AutoSize = true;
            this.lblPulgadas1.Location = new System.Drawing.Point(49, 393);
            this.lblPulgadas1.Name = "lblPulgadas1";
            this.lblPulgadas1.Size = new System.Drawing.Size(54, 13);
            this.lblPulgadas1.TabIndex = 9;
            this.lblPulgadas1.Text = "Pulgadas:";
            // 
            // lblPulgadas2
            // 
            this.lblPulgadas2.AutoSize = true;
            this.lblPulgadas2.Location = new System.Drawing.Point(378, 408);
            this.lblPulgadas2.Name = "lblPulgadas2";
            this.lblPulgadas2.Size = new System.Drawing.Size(54, 13);
            this.lblPulgadas2.TabIndex = 10;
            this.lblPulgadas2.Text = "Pulgadas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPulgadas2);
            this.Controls.Add(this.lblPulgadas1);
            this.Controls.Add(this.lblHercios2);
            this.Controls.Add(this.lblHercios1);
            this.Controls.Add(this.lblResolución2);
            this.Controls.Add(this.lblResolución1);
            this.Controls.Add(this.lblPanel2);
            this.Controls.Add(this.lblPanel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblPanel1;
        private System.Windows.Forms.Label lblPanel2;
        private System.Windows.Forms.Label lblResolución1;
        private System.Windows.Forms.Label lblResolución2;
        private System.Windows.Forms.Label lblHercios1;
        private System.Windows.Forms.Label lblHercios2;
        private System.Windows.Forms.Label lblPulgadas1;
        private System.Windows.Forms.Label lblPulgadas2;
        private System.Windows.Forms.Button button1;
    }
}