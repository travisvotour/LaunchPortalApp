namespace ModernUI
{
    partial class usrCtrlWebLoginPortal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbGmail = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGithub = new System.Windows.Forms.RadioButton();
            this.rbBrightspace = new System.Windows.Forms.RadioButton();
            this.lblSite = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(157, 287);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 21);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(157, 351);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(288, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(288, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(311, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbGmail.Location = new System.Drawing.Point(56, 41);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(74, 25);
            this.rbGmail.TabIndex = 6;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            this.rbGmail.CheckedChanged += new System.EventHandler(this.rbGmail_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGithub);
            this.groupBox1.Controls.Add(this.rbBrightspace);
            this.groupBox1.Controls.Add(this.rbGmail);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(97, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbGithub
            // 
            this.rbGithub.AutoSize = true;
            this.rbGithub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGithub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbGithub.Location = new System.Drawing.Point(515, 41);
            this.rbGithub.Name = "rbGithub";
            this.rbGithub.Size = new System.Drawing.Size(84, 25);
            this.rbGithub.TabIndex = 8;
            this.rbGithub.TabStop = true;
            this.rbGithub.Text = "GitHub";
            this.rbGithub.UseVisualStyleBackColor = true;
            this.rbGithub.CheckedChanged += new System.EventHandler(this.rbGithub_CheckedChanged);
            // 
            // rbBrightspace
            // 
            this.rbBrightspace.AutoSize = true;
            this.rbBrightspace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBrightspace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBrightspace.Location = new System.Drawing.Point(272, 41);
            this.rbBrightspace.Name = "rbBrightspace";
            this.rbBrightspace.Size = new System.Drawing.Size(123, 25);
            this.rbBrightspace.TabIndex = 7;
            this.rbBrightspace.TabStop = true;
            this.rbBrightspace.Text = "BrightSpace";
            this.rbBrightspace.UseVisualStyleBackColor = true;
            this.rbBrightspace.CheckedChanged += new System.EventHandler(this.rbBrightspace_CheckedChanged);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSite.Location = new System.Drawing.Point(351, 231);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(159, 28);
            this.lblSite.TabIndex = 8;
            this.lblSite.Text = "Gmail Login:";
            this.lblSite.Click += new System.EventHandler(this.lblSite_Click);
            // 
            // usrCtrlWebLoginPortal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "usrCtrlWebLoginPortal";
            this.Size = new System.Drawing.Size(852, 514);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbGmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGithub;
        private System.Windows.Forms.RadioButton rbBrightspace;
        private System.Windows.Forms.Label lblSite;
    }
}
