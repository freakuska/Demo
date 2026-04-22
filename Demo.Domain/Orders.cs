using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    class Orders
    {
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CreatedAt { get; set; }


        public virtual Users User { get; set; }
        public virtual OrderStatuses Status { get; set; }
        public virtual PickupPoints PickupPoints { get; set; }
    }
}
