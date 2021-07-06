﻿using System.Collections.Generic;
using System.Linq;
using MimeKit;

namespace simpemail.EmailConf
{
    public class MessageEmailSend
    {
        public MessageEmailSend(IEnumerable<string> to,string subject,string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress(x)));
            Subject = subject;
            Content = content;
        }
        public List<MailboxAddress> To
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Content
        {
            get;
            set;
        }
    }
}
