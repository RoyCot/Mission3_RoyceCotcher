using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3_RoyceCotcher.Models
{
    public class GradeCalculatorModel
    {
        [Range(0, 100)]
        public int Assign { get; set; }
        [Range(0, 100)]
        public int Group { get; set; }
        [Range(0, 100)]
        public int Quiz { get; set; }
        [Range(0, 100)]
        public int Exam { get; set; }
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}
