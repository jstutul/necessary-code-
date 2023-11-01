using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public interface ISMSHost
    {
        string Username { get; }
        string Password { get; }
        string MobileNo { get; }
    }
}
