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
     
    }
}
