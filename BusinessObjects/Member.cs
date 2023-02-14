using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId {get;set; }
        [StringLength(40)]
        public string? Email { get; set; }
        [StringLength(40)]
        public string? CompanyName { get; set; }
        [StringLength(40)]
        public string? City { get; set; }
        [StringLength(40)]
        public string? Country { get; set; }
        [StringLength(200)]
        public string? Password { get; set; }

        public virtual ICollection<Order> Orders
        { get; set; }
    }
}
