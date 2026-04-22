using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    class OrderStatuses
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool IsTerminal { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
