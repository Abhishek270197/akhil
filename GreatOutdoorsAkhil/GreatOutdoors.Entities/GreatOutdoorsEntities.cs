using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    public class Order
    {
        public static int OrderId = 0;
        public DateTime DateOfOrder { get; set; }
        public int CartId { get; set; }
    }
}
