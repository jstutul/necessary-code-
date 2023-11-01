using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class EmailModel
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public bool IsBodyHtml { get; set; }
        public List<EmailAttachment> Attachments { get; set; }
    }
}
