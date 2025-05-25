using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    public class Customer:Person
    {
       public List<Purchase> PurchaseList { get; set; } = new List<Purchase>();
       public List<Consultation> ConsultationList { get; set; } = new List<Consultation>();
        public List<Batch> BatchList { get; set; } = new List<Batch>();
    }
}
