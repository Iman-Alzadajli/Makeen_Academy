using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    public class Consultation
    {
        [Key]
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }

        public string Purpose { get; set; }
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
