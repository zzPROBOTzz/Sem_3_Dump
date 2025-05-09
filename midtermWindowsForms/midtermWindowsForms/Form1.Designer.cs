namespace midtermWindowsForms
{
    partial class frmLengthConvertor
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
            this.btnM_Yd = new System.Windows.Forms.Button();
            this.btnKm_Mile = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLength = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnM_Yd
            // 
            this.btnM_Yd.Location = new System.Drawing.Point(34, 74);
            this.btnM_Yd.Name = "btnM_Yd";
            this.btnM_Yd.Size = new System.Drawing.Size(160, 35);
            this.btnM_Yd.TabIndex = 1;
            this.btnM_Yd.Text = "&1st conversion";
            this.btnM_Yd.UseVisualStyleBackColor = true;
            this.btnM_Yd.Click += new System.EventHandler(this.btnM_Yd_Click);
            // 
            // btnKm_Mile
            // 
            this.btnKm_Mile.Location = new System.Drawing.Point(34, 138);
            this.btnKm_Mile.Name = "btnKm_Mile";
            this.btnKm_Mile.Size = new System.Drawing.Size(160, 35);
            this.btnKm_Mile.TabIndex = 3;
            this.btnKm_Mile.Text = "&2nd conversion";
            this.btnKm_Mile.UseVisualStyleBackColor = true;
            this.btnKm_Mile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(55, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the value(s) of metric length to convert. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(200, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Metric m :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(200, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "MetricKm :";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(293, 79);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 22);
            this.txtbox1.TabIndex = 0;
            this.txtbox1.Text = "0";
            this.txtbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(293, 141);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(100, 22);
            this.txtBox4.TabIndex = 2;
            this.txtBox4.Text = "0";
            this.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(421, 67);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ReadOnly = true;
            this.txtBox2.Size = new System.Drawing.Size(100, 22);
            this.txtBox2.TabIndex = 9;
            this.txtBox2.TabStop = false;
            this.txtBox2.Text = "0";
            this.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(421, 96);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.ReadOnly = true;
            this.txtBox3.Size = new System.Drawing.Size(100, 22);
            this.txtBox3.TabIndex = 10;
            this.txtBox3.TabStop = false;
            this.txtBox3.Text = "0";
            this.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(421, 153);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.ReadOnly = true;
            this.txtBox6.Size = new System.Drawing.Size(100, 22);
            this.txtBox6.TabIndex = 12;
            this.txtBox6.TabStop = false;
            this.txtBox6.Text = "0";
            this.txtBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(421, 124);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.ReadOnly = true;
            this.txtBox5.Size = new System.Drawing.Size(100, 22);
            this.txtBox5.TabIndex = 11;
            this.txtBox5.TabStop = false;
            this.txtBox5.Text = "0";
            this.txtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(527, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = ": cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(527, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = ": US mile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(527, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = ": m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(527, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = ": US yd";
            // 
            // cboLength
            // 
            this.cboLength.FormattingEnabled = true;
            this.cboLength.Items.AddRange(new object[] {
            "m --> cm --> yd   ",
            "km --> m --> miles "});
            this.cboLength.Location = new System.Drawing.Point(232, 204);
            this.cboLength.Name = "cboLength";
            this.cboLength.Size = new System.Drawing.Size(182, 24);
            this.cboLength.TabIndex = 6;
            // 
            // frmLengthConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 343);
            this.Controls.Add(this.cboLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKm_Mile);
            this.Controls.Add(this.btnM_Yd);
            this.Name = "frmLengthConvertor";
            this.Text = "MeetHingu2412591";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnM_Yd;
        private System.Windows.Forms.Button btnKm_Mile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox6;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLength;
    }
}

