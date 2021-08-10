using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Reports
{
    public class StudentsWithDegreeRangeParameters : AbstractReportParameters
    {
        public int TrainerId { get; set; }
        public int ResultFrom { get; set; }
        public int ResultTo { get; set; }
    }
}
