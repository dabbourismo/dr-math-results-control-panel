using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Enums
{
    public enum EnumAgeRange
    {
        [Description("تحت 6 سنين")]
        Under6,
        [Description("تحت 7 سنين")]
        Under7,
        [Description("تحت 8 سنين")]
        Under8,
        [Description("تحت 9 سنين")]
        Under9,
        [Description("تحت 10 سنين")]
        Under10,
        [Description("فوق 10 سنين")]
        Over10
    }
}
