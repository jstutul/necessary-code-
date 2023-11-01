using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class ClientSMSModel : SMS
    {
        public string ProjectCode { get; set; }
        public string FileNo { get; set; }
        public string SMSType { get; set; }
        public int MRId { get; set; }
    }
}
