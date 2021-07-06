
namespace simpemail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainpanel = new System.Windows.Forms.Panel();
            this.Sendemaillog = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.fromtext = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.contenttext = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.Label();
            this.subjecttext = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.settingspanel = new System.Windows.Forms.Panel();
            this.simpemail = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.porttext = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.smtpservertext = new System.Windows.Forms.TextBox();
            this.smtpserver = new System.Windows.Forms.Label();
            this.userpasswordtext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.settingspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.Sendemaillog);
            this.mainpanel.Controls.Add(this.from);
            this.mainpanel.Controls.Add(this.fromtext);
            this.mainpanel.Controls.Add(this.sendbutton);
            this.mainpanel.Controls.Add(this.contenttext);
            this.mainpanel.Controls.Add(this.content);
            this.mainpanel.Controls.Add(this.subjecttext);
            this.mainpanel.Controls.Add(this.subject);
            this.mainpanel.Location = new System.Drawing.Point(12, 12);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(487, 498);
            this.mainpanel.TabIndex = 0;
            // 
            // Sendemaillog
            // 
            this.Sendemaillog.AutoSize = true;
            this.Sendemaillog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sendemaillog.Location = new System.Drawing.Point(191, 25);
            this.Sendemaillog.Name = "Sendemaillog";
            this.Sendemaillog.Size = new System.Drawing.Size(45, 18);
            this.Sendemaillog.TabIndex = 15;
            this.Sendemaillog.Text = "Send";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(24, 50);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(48, 17);
            this.from.TabIndex = 13;
            this.from.Text = "E-Mail";
            // 
            // fromtext
            // 
            this.fromtext.Location = new System.Drawing.Point(24, 81);
            this.fromtext.Name = "fromtext";
            this.fromtext.Size = new System.Drawing.Size(444, 25);
            this.fromtext.TabIndex = 14;
            // 
            // sendbutton
            // 
            this.sendbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.sendbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendbutton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendbutton.ForeColor = System.Drawing.Color.White;
            this.sendbutton.Location = new System.Drawing.Point(24, 405);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(102, 37);
            this.sendbutton.TabIndex = 6;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // contenttext
            // 
            this.contenttext.Location = new System.Drawing.Point(24, 188);
            this.contenttext.Multiline = true;
            this.contenttext.Name = "contenttext";
            this.contenttext.Size = new System.Drawing.Size(444, 211);
            this.contenttext.TabIndex = 5;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.content.Location = new System.Drawing.Point(24, 166);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(76, 19);
            this.content.TabIndex = 4;
            this.content.Text = "Content:";
            // 
            // subjecttext
            // 
            this.subjecttext.Location = new System.Drawing.Point(24, 135);
            this.subjecttext.Name = "subjecttext";
            this.subjecttext.Size = new System.Drawing.Size(444, 25);
            this.subjecttext.TabIndex = 3;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subject.Location = new System.Drawing.Point(24, 113);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(73, 19);
            this.subject.TabIndex = 2;
            this.subject.Text = "Subject:";
            // 
            // settingspanel
            // 
            this.settingspanel.Controls.Add(this.simpemail);
            this.settingspanel.Controls.Add(this.save);
            this.settingspanel.Controls.Add(this.porttext);
            this.settingspanel.Controls.Add(this.port);
            this.settingspanel.Controls.Add(this.smtpservertext);
            this.settingspanel.Controls.Add(this.smtpserver);
            this.settingspanel.Controls.Add(this.userpasswordtext);
            this.settingspanel.Controls.Add(this.password);
            this.settingspanel.Controls.Add(this.usernametext);
            this.settingspanel.Controls.Add(this.username);
            this.settingspanel.Controls.Add(this.settings);
            this.settingspanel.Location = new System.Drawing.Point(559, 13);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(475, 497);
            this.settingspanel.TabIndex = 1;
            // 
            // simpemail
            // 
            this.simpemail.AutoSize = true;
            this.simpemail.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simpemail.Location = new System.Drawing.Point(119, 380);
            this.simpemail.Name = "simpemail";
            this.simpemail.Size = new System.Drawing.Size(238, 41);
            this.simpemail.TabIndex = 12;
            this.simpemail.Text = "Simp Email";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Goldenrod;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Location = new System.Drawing.Point(19, 265);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 31);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // porttext
            // 
            this.porttext.Location = new System.Drawing.Point(19, 234);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(439, 25);
            this.porttext.TabIndex = 10;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(19, 214);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(35, 17);
            this.port.TabIndex = 9;
            this.port.Text = "Port";
            // 
            // smtpservertext
            // 
            this.smtpservertext.Location = new System.Drawing.Point(19, 186);
            this.smtpservertext.Name = "smtpservertext";
            this.smtpservertext.Size = new System.Drawing.Size(439, 25);
            this.smtpservertext.TabIndex = 8;
            // 
            // smtpserver
            // 
            this.smtpserver.AutoSize = true;
            this.smtpserver.Location = new System.Drawing.Point(19, 165);
            this.smtpserver.Name = "smtpserver";
            this.smtpserver.Size = new System.Drawing.Size(90, 17);
            this.smtpserver.TabIndex = 7;
            this.smtpserver.Text = "SmtpServer:";
            // 
            // userpasswordtext
            // 
            this.userpasswordtext.Location = new System.Drawing.Point(19, 133);
            this.userpasswordtext.Name = "userpasswordtext";
            this.userpasswordtext.Size = new System.Drawing.Size(439, 25);
            this.userpasswordtext.TabIndex = 4;
            this.userpasswordtext.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(19, 112);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(74, 17);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(19, 80);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(439, 25);
            this.usernametext.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(19, 58);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 18);
            this.username.TabIndex = 1;
            this.username.Text = "UserName:";
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings.Location = new System.Drawing.Point(208, 24);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(79, 22);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1046, 522);
            this.Controls.Add(this.settingspanel);
            this.Controls.Add(this.mainpanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simp Email";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.settingspanel.ResumeLayout(false);
            this.settingspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox contenttext;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.TextBox subjecttext;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Label simpemail;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox porttext;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox smtpservertext;
        private System.Windows.Forms.Label smtpserver;
        private System.Windows.Forms.TextBox userpasswordtext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.TextBox fromtext;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label Sendemaillog;
    }
}

