using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    class OrderTabs
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtOrder { get; set; }
        public decimal DiscountAtOrder { get; set; }
        public DateTime CreatedAt { get; set; }


        public virtual Orders Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
