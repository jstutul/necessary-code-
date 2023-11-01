using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class ClientEmailModel : EmailModel
    {
        public string ProjectCode { get; set; }
        public string FileNo { get; set; }
        public string EmailType { get; set; }
        public int IsBodyImage { get; set; }
    }
}
