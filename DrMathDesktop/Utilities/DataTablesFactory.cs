using DrMathDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Utilities
{
    public static class DataTablesFactory
    {
        public static DataTable TrainersDataTable(List<Trainer> items)
        {
            DataTable dt = new DataTable();
          //  dt.Columns.Add("المعرف", typeof(int));
            dt.Columns.Add("الرقم السري", typeof(int));
            dt.Columns.Add("الاسم", typeof(string));

            foreach (var item in items)
            {
                DataRow dr = dt.NewRow();
             //   dr["المعرف"] = item.Id;
                dr["الرقم السري"] = item.Id;
                dr["الاسم"] = item.Name;

                dt.Rows.Add(dr);
            }
            return dt;
        }


        public static DataTable StudentsDataTable(List<Student> items)
        {
            DataTable dt = new DataTable();
          //  dt.Columns.Add("المعرف", typeof(int));
            dt.Columns.Add("الرقم السري", typeof(string));
            dt.Columns.Add("الاسم العربي", typeof(string));
            dt.Columns.Add("الاسم الانجليزي", typeof(string));
            dt.Columns.Add("تاريخ الميلاد", typeof(DateTime));
            dt.Columns.Add("المستوى", typeof(string));
            dt.Columns.Add("المرحلة", typeof(string));
            dt.Columns.Add("لغة الاختبار", typeof(string));
            dt.Columns.Add("المحافظة", typeof(string));
            dt.Columns.Add("المدرب", typeof(string));

            foreach (var item in items)
            {
                DataRow dr = dt.NewRow();
           //     dr["المعرف"] = item.Id;
                dr["الرقم السري"] = item.Id;
                dr["الاسم العربي"] = item.NameArabic;
                dr["الاسم الانجليزي"] = item.NameEnglish;
                dr["تاريخ الميلاد"] = item.BirthDate.ToString("yyyy-MM-dd");

               

                switch (item.Level)
                {
                    case Enums.EnumStudentLevel.Zero:
                        dr["المستوى"] = "صفر";
                        break;
                    case Enums.EnumStudentLevel.One:
                        dr["المستوى"] = "الاول";
                        break;
                    case Enums.EnumStudentLevel.Two:
                        dr["المستوى"] = "الثاني";
                        break;
                    case Enums.EnumStudentLevel.Three:
                        dr["المستوى"] = "الثالث";
                        break;
                    case Enums.EnumStudentLevel.Four:
                        dr["المستوى"] = "الرابع";
                        break;
                    case Enums.EnumStudentLevel.Five:
                        dr["المستوى"] = "الخامس";
                        break;
                    case Enums.EnumStudentLevel.Six:
                        dr["المستوى"] = "السادس";
                        break;
                    case Enums.EnumStudentLevel.Seven:
                        dr["المستوى"] = "السابع";
                        break;
                    case Enums.EnumStudentLevel.Eight:
                        dr["المستوى"] = "الثامن";
                        break;
                    default:
                        break;
                }

                switch (item.AgeRange)
                {
                    case Enums.EnumAgeRange.Under6:
                        dr["المرحلة"] = "تحت 6 سنين";
                        break;
                    case Enums.EnumAgeRange.Under7:
                        dr["المرحلة"] = "تحت 7 سنين";
                        break;
                    case Enums.EnumAgeRange.Under8:
                        dr["المرحلة"] = "تحت 8 سنين";
                        break;
                    case Enums.EnumAgeRange.Under9:
                        dr["المرحلة"] = "تحت 9 سنين";
                        break;
                    case Enums.EnumAgeRange.Under10:
                        dr["المرحلة"] = "تحت 10 سنين";
                        break;
                    case Enums.EnumAgeRange.Over10:
                        dr["المرحلة"] = "فوق 10 سنين";
                        break;
                    default:
                        break;
                }

                switch (item.ExamLanguage)
                {
                    case Enums.EnumExamLanguage.Arabic:
                        dr["لغة الاختبار"] = "عربي";
                        break;
                    case Enums.EnumExamLanguage.English:
                        dr["لغة الاختبار"] = "English";
                        break;
                    default:
                        break;
                }

                dr["المحافظة"] = item.Governate;
                dr["المدرب"] = item.Trainer.Name;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DataTable ResultsDataTable(List<Result> items)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("المعرف", typeof(int));
            dt.Columns.Add("الرقم السري للطالب", typeof(string));
            dt.Columns.Add("اسم الطالب", typeof(string));
            dt.Columns.Add("المستوى الخاص بالدرجة", typeof(string));
            dt.Columns.Add("الدرجة", typeof(string));

            foreach (var item in items)
            {
                DataRow dr = dt.NewRow();
                dr["المعرف"] = item.Id;
                dr["الرقم السري للطالب"] = item.StudentId;
                dr["اسم الطالب"] = item.Student.NameArabic;
                dr["المستوى الخاص بالدرجة"] = item.Level;
                dr["الدرجة"] = item.ResultValue;

                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
