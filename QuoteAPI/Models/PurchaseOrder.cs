using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class PurchaseOrder
    {
        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public string ShippingPlace { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        public DateTime? EstimatedShipdate { get; set; }
        public int? OrderedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
