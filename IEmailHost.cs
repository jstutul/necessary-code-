using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public interface IEmailHost
    {
        string Server { get; }
        string Address { get; }
        string Password { get; }
        int Port { get; }
        bool EnableSSL { get; }
        string DisplayName { get; }
    }
}
