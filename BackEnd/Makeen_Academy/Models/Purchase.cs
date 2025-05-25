using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string DeliveryLocation { get; set; }

       public Book Book { get; set; }
        public int BookId { get; set; }

    }
}
