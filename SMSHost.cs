using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class SMSHost : ISMSHost
    {
        private readonly IConfiguration _config;
        public SMSHost(IConfiguration config)
        {
            _config = config;
            var smsHost = _config.GetSection("SMSHost");
        }

        public string Username => _config.GetSection("SMSHost")["Username"];
        public string Password => _config.GetSection("SMSHost")["Password"];
        public string MobileNo => _config.GetSection("SMSHost")["MobileNo"];
    }
}
