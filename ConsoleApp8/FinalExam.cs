using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class FinalExam
    {
        public abstract double GetEstimation();
    }

    class Test : FinalExam
    {
        public float Score { get; set; }
                             
        public override double GetEstimation() => Score / 20;
    }

    class Exam : FinalExam
    {
        public float SumEst { get; set; }
        public float Quantity { get; set; }

        public override double GetEstimation() => SumEst / Quantity;
    }

    
}
