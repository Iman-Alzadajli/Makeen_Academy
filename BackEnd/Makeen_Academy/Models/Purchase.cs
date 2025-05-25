using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    internal class Purchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string DeliveryLocation { get; set; }
    }
}
