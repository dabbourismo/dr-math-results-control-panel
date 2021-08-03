using DrMathDesktop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Models
{
    public class Result
    {
        public int Id { get; set; }

        public decimal ResultValue { get; set; }

        public EnumStudentLevel Level { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
