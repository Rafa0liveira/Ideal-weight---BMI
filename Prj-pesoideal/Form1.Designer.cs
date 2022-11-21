namespace Prj_pesoideal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        
        private void InitializeComponent()
        {
            this.txtname = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.btnidealweight = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.AccessibleName = "txtname";
            this.txtname.Location = new System.Drawing.Point(12, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 29);
            this.txtname.TabIndex = 0;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(140, 98);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(144, 32);
            this.cmbgender.TabIndex = 1;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(12, 98);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(80, 29);
            this.txtheight.TabIndex = 2;
            // 
            // btnidealweight
            // 
            this.btnidealweight.BackColor = System.Drawing.Color.Transparent;
            this.btnidealweight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnidealweight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnidealweight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnidealweight.Location = new System.Drawing.Point(12, 233);
            this.btnidealweight.Name = "btnidealweight";
            this.btnidealweight.Size = new System.Drawing.Size(125, 38);
            this.btnidealweight.TabIndex = 3;
            this.btnidealweight.Text = "Ideal &Weight";
            this.btnidealweight.UseVisualStyleBackColor = false;
            this.btnidealweight.Click += new System.EventHandler(this.btnidealweight_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(603, 514);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(86, 38);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Quit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(118, 151);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(69, 38);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(188, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sex";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(12, 160);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(80, 29);
            this.txtweight.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weight";
            // 
            // btnBMI
            // 
            this.btnBMI.BackColor = System.Drawing.Color.Transparent;
            this.btnBMI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBMI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMI.Location = new System.Drawing.Point(12, 277);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(125, 31);
            this.btnBMI.TabIndex = 11;
            this.btnBMI.Text = "&BMI";
            this.btnBMI.UseVisualStyleBackColor = false;
            this.btnBMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prj_pesoideal.Properties.Resources.Female_Yoga_Pose_Silhouette_13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 564);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnidealweight);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtname);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Button btnidealweight;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBMI;
    }
}

