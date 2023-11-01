using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class EmailHost : IEmailHost
    {
        private readonly IConfiguration _config;
        public EmailHost(IConfiguration config)
        {
            _config = config;
        }
        public string Server => _config.GetSection("EmailHost")["Server"];
        public string Address => _config.GetSection("EmailHost")["Address"];
        public string Password => _config.GetSection("EmailHost")["Password"];
        public int Port => int.Parse(_config.GetSection("EmailHost")["Port"]);
        public bool EnableSSL => _config.GetSection("EmailHost")["EnableSSL"] == "1";
        public string DisplayName => _config.GetSection("EmailHost")["DisplayName"];
    }
}
