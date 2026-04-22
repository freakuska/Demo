using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    class Users
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Login {  get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Roles Roles { get; set; }

    }
}
