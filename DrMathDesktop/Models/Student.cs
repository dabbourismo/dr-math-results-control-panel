using DrMathDesktop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string NameArabic { get; set; }

        public string NameEnglish { get; set; }

        public DateTime BirthDate { get; set; }

        public EnumStudentLevel  Level { get; set; }

        public EnumExamLanguage ExamLanguage { get; set; }

        public EnumAgeRange AgeRange { get; set; }

        public string Governate { get; set; }


        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }


    }
}
