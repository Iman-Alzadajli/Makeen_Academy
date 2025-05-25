using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Models
{
    public class Batch
    {
        public int Id { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public int TrainerId { get; set; }
        public int CourseId { get; set; }

        //navigation properties
        public Trainer trainers { get; set; }

        public Course courses { get; set; }


    }
}
