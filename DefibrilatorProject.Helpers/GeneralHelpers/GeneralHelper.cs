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
            date = DateTime.SpecifyKind(date, DateTimeKind.Utc);
            var currentUserTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time"); // GMT:+07
            return TimeZoneInfo.ConvertTime(date, currentUserTimeZoneInfo);
        }
    }
}
