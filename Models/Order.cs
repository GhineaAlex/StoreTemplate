using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
