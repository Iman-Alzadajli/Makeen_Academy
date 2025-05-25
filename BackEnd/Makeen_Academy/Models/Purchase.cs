using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        // Foreign Key to Book

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }

    }
}
