using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DefibrilatorProject.Helpers.GeneralHelpers
{
    public class GeneralHelper
    {
        public DateTime FormatDate(DateTime date)
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            DateTime utc = TimeZoneInfo.ConvertTimeToUtc(date, tz);
            return utc;
        }
    }
}
