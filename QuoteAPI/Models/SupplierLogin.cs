using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class SupplierLogin
    {
        public int SupplierId { get; set; }
        public string Website { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }
    }
}
