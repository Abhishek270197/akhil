using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    class Cart
    {
        public int CartId { get; set; }
        public int AddressID { get; set; }
        public int RetailerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int PriceAtOrder { get; set; }
        public int TotalAmount { get; set; }
    }
}
