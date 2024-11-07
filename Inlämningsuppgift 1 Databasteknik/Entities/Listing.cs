using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1_Databasteknik.Entities
{
    public class Listing
    {
        public int ListingID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
