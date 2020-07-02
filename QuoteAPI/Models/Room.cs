using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class Room
    {
        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public decimal? FloorCeiling { get; set; }
        public decimal? TotCeiling { get; set; }
        public decimal? BotFloor { get; set; }
        public decimal? LootObject { get; set; }
        public decimal? RootObject { get; set; }
        public decimal? InsideHorizontal { get; set; }
        public decimal? InsideVertical { get; set; }
        public decimal? OutsideHorizontal { get; set; }
        public decimal? OutsideVertical { get; set; }
        public decimal? TrimDepth { get; set; }
        public decimal? InsideDepth { get; set; }
        public string Sill { get; set; }
        public string Control { get; set; }
        public string Notes { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
