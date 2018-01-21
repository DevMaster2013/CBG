using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Enums
{
    public enum TimeScaleUnit : long
    {
        Seconds = 1,
        Minutes = Seconds * 60,
        Hours = Minutes * 60,
        Days = Hours * 24,
        Months = Days * 30,
        Years = Months * 12
    }
}
