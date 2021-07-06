using System;
using MailKit.Net.Smtp;
using MimeKit;
namespace simpemail.EmailConf
{
    public class EmailSend
    {
        public EmailSend()
        {

        }
        public void SendEmail(MessageEmailSend mess)
        {
            MimeMessage msr = CreateMessage(mess);
            SendSmtpEmail(msr);
        }
        private MimeMessage CreateMessage(MessageEmailSend message)
        {
            MimeMessage msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(Settings.Default.From));
            msg.To.AddRange(message.To);
            msg.Subject = message.Subject;
            msg.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            return msg;
        }
        private void SendSmtpEmail(MimeMessage mimmesg)
        {
            SmtpClient smtp = new SmtpClient();

            try
            {
                smtp.Connect(Settings.Default.SmtpServer, Settings.Default.Port, false);
                smtp.AuthenticationMechanisms.Remove("XOAUTH2");
                smtp.Authenticate(Settings.Default.UserName, Settings.Default.Password);
                smtp.Send(mimmesg);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error ", ex.Message);
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }
        }
    }
}
