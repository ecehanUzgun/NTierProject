
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class User:IdentityUser
    {
        public string Address { get; set; }

        // Relational properties
        // 1 order -> 1 user // 1 user -> n order
        public List<Order> Orders { get; set; }
    }
}
