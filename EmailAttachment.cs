using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class EmailAttachment
    {
        public string AttachmentFileName { get; set; }
        public Stream AttachmentFile { get; set; }
    }
}
