using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class SMSModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
    }
}
