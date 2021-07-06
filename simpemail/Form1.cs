using System;
using System.Windows.Forms;
using simpemail.EmailConf;
namespace simpemail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e)
        {
            Settings.Default.UserName = usernametext.Text;
            Settings.Default.Password = userpasswordtext.Text;
            Settings.Default.SmtpServer = smtpservertext.Text;
            Settings.Default.From = usernametext.Text;
            Settings.Default.Port = Convert.ToInt32(porttext.Text);
            MessageBox.Show("Saved");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.UserName = usernametext.Text;
            Settings.Default.Password = userpasswordtext.Text;
            Settings.Default.SmtpServer = smtpservertext.Text;
            Settings.Default.From = fromtext.Text;
            Settings.Default.Port = Convert.ToInt32(porttext.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernametext.Text = Settings.Default.UserName;
            userpasswordtext.Text = Settings.Default.Password;
            smtpservertext.Text = Settings.Default.SmtpServer;
            fromtext.Text = Settings.Default.From;
            porttext.Text = Convert.ToString(Settings.Default.Port);
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            string[] email = { fromtext.Text };
            MessageEmailSend emailsend = new MessageEmailSend(email, subjecttext.Text, contenttext.Text);
            EmailSend emailsenders = new EmailSend();
            emailsenders.SendEmail(emailsend);
            MessageBox.Show("Message Sended");
        }
    }
}
