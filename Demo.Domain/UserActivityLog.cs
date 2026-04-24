using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class UserActivityLog
    {
        public long Id { get; set; }
        public string ActionCode { get; set; }
        public string EntityName { get; set; }
        public long EntityId { get; set; }
        public IPAddress IPAddress { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedAt { get; set; } 

        public virtual Users User { get; set; }
    }
}
