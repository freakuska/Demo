using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class Products
    {
        public long Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
        public long ManufacturerId { get; set; }
        public long SupplyId { get; set; }
        public string Unit {  get; set; }
        public decimal CurrentDiscount { get; set; }
        public string? ImagePath { get; set; }
        public decimal Price { get; set; }
        public int StokQuantity { get; set; }
        public DateTime CreatedAt { get; set; }


        public virtual Categories Categories { get; set; }
        public virtual Manufacturers Manufacturers { get; set; }
        public virtual Supplies Supplies { get; set; }
    }
}
