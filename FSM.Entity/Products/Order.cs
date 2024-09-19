using FS.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Entity.Products
{
    public class Order : BaseEntity
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }
        public int OrderNumber { get; set; }
        public double TotalPrice { get; set; }

        public int Quantity { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
