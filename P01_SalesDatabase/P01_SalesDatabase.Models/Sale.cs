using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime date { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }

    }
}
