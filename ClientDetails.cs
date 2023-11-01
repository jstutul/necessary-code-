using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USBanglaSMSApplication.Models
{
    public class ClientDetails : Client
    {
        public decimal ReceivableAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string Block { get; set; }
        public string Sector { get; set; }
        public string Road { get; set; }
        public string PlotNo { get; set; }
        public decimal PlotSize { get; set; }
        public decimal PlotPrice { get; set; }
        public string SMSText { get; set; }
        public decimal CollectionAmount { get; set; }
        public string CollectionDate { get; set; }
        public string MoneyReceiptNo { get; set; }
        public int MRId { get; set; }
        public string EntryBy { get; set; }
        public string EntryTime { get; set; }
    }
}
