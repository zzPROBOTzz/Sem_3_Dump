namespace Cineplexx
{
    partial class Form1
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
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttondisplay = new System.Windows.Forms.Button();
            this.buttoupdate = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.listBoxmoviedetail = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDurationminute = new System.Windows.Forms.TextBox();
            this.textBoxDurationhours = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelActor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.moviecodetextbox = new System.Windows.Forms.TextBox();
            this.actortextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoninsert
            // 
            this.buttoninsert.Location = new System.Drawing.Point(16, 236);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(75, 23);
            this.buttoninsert.TabIndex = 4;
            this.buttoninsert.Text = "INSERT";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttondisplay
            // 
            this.buttondisplay.Location = new System.Drawing.Point(16, 265);
            this.buttondisplay.Name = "buttondisplay";
            this.buttondisplay.Size = new System.Drawing.Size(75, 23);
            this.buttondisplay.TabIndex = 5;
            this.buttondisplay.Text = "DISPLAY";
            this.buttondisplay.UseVisualStyleBackColor = true;
            this.buttondisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoupdate
            // 
            this.buttoupdate.Location = new System.Drawing.Point(16, 294);
            this.buttoupdate.Name = "buttoupdate";
            this.buttoupdate.Size = new System.Drawing.Size(75, 23);
            this.buttoupdate.TabIndex = 6;
            this.buttoupdate.Text = "UPDATE";
            this.buttoupdate.UseVisualStyleBackColor = true;
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(16, 323);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 23);
            this.buttonreset.TabIndex = 7;
            this.buttonreset.Text = "RESET";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(16, 352);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 8;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(16, 381);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 9;
            this.buttonexit.Text = "EXIT";
            this.buttonexit.UseVisualStyleBackColor = true;
            // 
            // listBoxmoviedetail
            // 
            this.listBoxmoviedetail.FormattingEnabled = true;
            this.listBoxmoviedetail.ItemHeight = 16;
            this.listBoxmoviedetail.Location = new System.Drawing.Point(156, 236);
            this.listBoxmoviedetail.Name = "listBoxmoviedetail";
            this.listBoxmoviedetail.Size = new System.Drawing.Size(447, 132);
            this.listBoxmoviedetail.TabIndex = 10;
            this.listBoxmoviedetail.SelectedIndexChanged += new System.EventHandler(this.listBoxmoviedetail_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDurationminute);
            this.groupBox2.Controls.Add(this.textBoxDurationhours);
            this.groupBox2.Controls.Add(this.labelDuration);
            this.groupBox2.Controls.Add(this.comboBoxtype);
            this.groupBox2.Controls.Add(this.comboBoxLanguage);
            this.groupBox2.Controls.Add(this.labelType);
            this.groupBox2.Controls.Add(this.labelLanguage);
            this.groupBox2.Location = new System.Drawing.Point(420, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 137);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBoxDurationminute
            // 
            this.textBoxDurationminute.Location = new System.Drawing.Point(161, 101);
            this.textBoxDurationminute.Name = "textBoxDurationminute";
            this.textBoxDurationminute.Size = new System.Drawing.Size(46, 22);
            this.textBoxDurationminute.TabIndex = 13;
            // 
            // textBoxDurationhours
            // 
            this.textBoxDurationhours.Location = new System.Drawing.Point(98, 101);
            this.textBoxDurationhours.Name = "textBoxDurationhours";
            this.textBoxDurationhours.Size = new System.Drawing.Size(46, 22);
            this.textBoxDurationhours.TabIndex = 12;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDuration.Location = new System.Drawing.Point(6, 101);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(57, 16);
            this.labelDuration.TabIndex = 5;
            this.labelDuration.Text = "Duration";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Location = new System.Drawing.Point(98, 63);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(121, 24);
            this.comboBoxtype.TabIndex = 4;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(98, 29);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLanguage.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelType.Location = new System.Drawing.Point(6, 63);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 16);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "MovieType";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLanguage.Location = new System.Drawing.Point(6, 31);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(68, 16);
            this.labelLanguage.TabIndex = 1;
            this.labelLanguage.Text = "Language";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCode.Location = new System.Drawing.Point(6, 63);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(77, 16);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "MovieCode";
            // 
            // labelActor
            // 
            this.labelActor.AutoSize = true;
            this.labelActor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelActor.Location = new System.Drawing.Point(6, 98);
            this.labelActor.Name = "labelActor";
            this.labelActor.Size = new System.Drawing.Size(38, 16);
            this.labelActor.TabIndex = 2;
            this.labelActor.Text = "Actor";
            this.labelActor.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "labelMovieTitle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(115, 31);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(100, 22);
            this.titletextbox.TabIndex = 3;
            this.titletextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // moviecodetextbox
            // 
            this.moviecodetextbox.Location = new System.Drawing.Point(115, 63);
            this.moviecodetextbox.Name = "moviecodetextbox";
            this.moviecodetextbox.Size = new System.Drawing.Size(100, 22);
            this.moviecodetextbox.TabIndex = 4;
            this.moviecodetextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // actortextbox
            // 
            this.actortextbox.Location = new System.Drawing.Point(115, 95);
            this.actortextbox.Name = "actortextbox";
            this.actortextbox.Size = new System.Drawing.Size(100, 22);
            this.actortextbox.TabIndex = 5;
            this.actortextbox.TextChanged += new System.EventHandler(this.actortextbox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actortextbox);
            this.groupBox1.Controls.Add(this.moviecodetextbox);
            this.groupBox1.Controls.Add(this.titletextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelActor);
            this.groupBox1.Controls.Add(this.labelCode);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "..";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxmoviedetail);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttoupdate);
            this.Controls.Add(this.buttondisplay);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttondisplay;
        private System.Windows.Forms.Button buttoupdate;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.ListBox listBoxmoviedetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxDurationhours;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxDurationminute;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelActor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.TextBox moviecodetextbox;
        private System.Windows.Forms.TextBox actortextbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

