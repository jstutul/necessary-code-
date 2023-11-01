using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class Email : MailMessage
    {
        private readonly IEmailHost _emailHost;
        public Email(IEmailHost emailHost, EmailModel email)
        {
            _emailHost = emailHost;
            From = new MailAddress(_emailHost.Address, _emailHost.DisplayName);
            Subject = email.Subject;
            Body = email.Body;
            IsBodyHtml = email.IsBodyHtml;
            To.Add(email.To);
            if (!string.IsNullOrEmpty(email.CC))
                CC.Add(email.CC);
            if (!string.IsNullOrEmpty(email.BCC))
                Bcc.Add(email.BCC);
            if (email.Attachments != null)
            {
                foreach (var att in email.Attachments)
                {
                    var attachment = new Attachment(att.AttachmentFile, new ContentType { Name = att.AttachmentFileName });
                    Attachments.Add(attachment);
                }
            }
        }
    }
}
