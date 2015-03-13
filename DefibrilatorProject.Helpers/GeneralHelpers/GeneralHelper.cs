using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace DefibrilatorProject.Helpers.GeneralHelpers
{
    public class GeneralHelper
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public DateTime FormatDate(DateTime date)
        {
            Logger.Info(date);
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            DateTime utc = TimeZoneInfo.ConvertTimeToUtc(date, tz);
            Logger.Info(utc);
            return utc;
        }
    }
}
