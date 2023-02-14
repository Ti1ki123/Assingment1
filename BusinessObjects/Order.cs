﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string? Frieght { get; set; }

        public virtual Member? Member { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails
        { get; set; }

    }
}
