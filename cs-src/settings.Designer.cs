
namespace SMTP
{
    partial class settings
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.serverAdressSMTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailToAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.mailAdress = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.portBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.serverAdressSMTP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mailToAdress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.mailAdress);
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 162);
            this.panel1.TabIndex = 12;
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.portBox.Location = new System.Drawing.Point(405, 4);
            this.portBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(82, 26);
            this.portBox.TabIndex = 13;
            this.portBox.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Receiver mail adress";
            // 
            // serverAdressSMTP
            // 
            this.serverAdressSMTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.serverAdressSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverAdressSMTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.serverAdressSMTP.Location = new System.Drawing.Point(147, 4);
            this.serverAdressSMTP.Name = "serverAdressSMTP";
            this.serverAdressSMTP.Size = new System.Drawing.Size(252, 26);
            this.serverAdressSMTP.TabIndex = 1;
            this.serverAdressSMTP.Text = "smtp.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sender mail pass";
            // 
            // mailToAdress
            // 
            this.mailToAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.mailToAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailToAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.mailToAdress.Location = new System.Drawing.Point(147, 100);
            this.mailToAdress.Name = "mailToAdress";
            this.mailToAdress.Size = new System.Drawing.Size(340, 26);
            this.mailToAdress.TabIndex = 4;
            this.mailToAdress.Text = "rvrelay@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server adress / port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sender mail adress";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.passBox.Location = new System.Drawing.Point(147, 68);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(340, 26);
            this.passBox.TabIndex = 5;
            this.passBox.Text = "dluORNeb0DswubSt3L";
            // 
            // mailAdress
            // 
            this.mailAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.mailAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.mailAdress.Location = new System.Drawing.Point(147, 36);
            this.mailAdress.Name = "mailAdress";
            this.mailAdress.Size = new System.Drawing.Size(340, 26);
            this.mailAdress.TabIndex = 2;
            this.mailAdress.Text = "danielmroz024@gmail.com";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(147, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 23);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "AES and RSA (generate key)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(525, 214);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.Text = "settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverAdressSMTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailToAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox mailAdress;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}