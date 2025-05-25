using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 2111a51fe15e0dcbb6cdef174323828927fec45e
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

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
   
    }
}
