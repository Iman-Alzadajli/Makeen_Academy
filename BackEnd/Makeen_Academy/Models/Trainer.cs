using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    public class Trainer:Person
    {
        List<Consultation> ConsultationList { get; set; } = new List<Consultation>();
        List<Batch> BatchList { get; set; } = new List<Batch>();
    }
}
