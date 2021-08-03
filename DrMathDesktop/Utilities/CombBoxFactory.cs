using DrMathDesktop.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Utilities
{
    public static class CombBoxFactory
    {
        public static readonly string Description = "Description";
        public static readonly string Value = "Value";

        public static object AgeRangeCombBox()
        {
            return Enum.GetValues(typeof(EnumAgeRange)).Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                 .OrderBy(item => item.value)
                 .ToList();
        }
    }
}
