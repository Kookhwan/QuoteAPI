using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectTag { get; set; }
        public int ClientId { get; set; }
        public string Status { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
