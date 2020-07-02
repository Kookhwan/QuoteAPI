using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class Drapery
    {
        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public int DraperyId { get; set; }
        public string TypeName { get; set; }
        public string TypeValue { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
