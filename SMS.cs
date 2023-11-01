using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class SMS
    {
        public string MobileNo { get; set; }
        public string Message { get; set; }
        public string MessageId { get; set; }
        public int SMSCount { get; set; }
        public int ErrorCode { get; set; }
    }
}
