using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class Orders
    {
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public long UserId { get; set; }
        public long StatusId { get; set; }
        public long PickupPointId { get; set; }


        public virtual Users User { get; set; }
        public virtual OrderStatuses Status { get; set; }
        public virtual PickupPoints PickupPoints { get; set; }
    }
}
