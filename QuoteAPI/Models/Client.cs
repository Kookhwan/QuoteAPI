using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteAPI.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string BizType { get; set; }
        public string BizYear { get; set; }
        public string Associations { get; set; }
        public string Recommender { get; set; }
        public string Hst { get; set; }
        public string Reference { get; set; }
        public string Mailing { get; set; }
        public string Term { get; set; }
        public DateTime Timestamp { get; set; }
        public string Comments { get; set; }
    }
}
