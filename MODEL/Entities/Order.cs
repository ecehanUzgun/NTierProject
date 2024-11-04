﻿using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public DateTime? ShippedDate { get; set; }//null

        //Relational Properties
        public List<OrderDetail> OrderDetail { get; set; }

        // 1 order -> 1 user // 1 user -> n order
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
