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
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public DateTime FormatDate(DateTime date)
        {
            _logger.Info(date);
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            DateTime utc = TimeZoneInfo.ConvertTimeToUtc(date, tz);
            _logger.Info(utc);
            return utc;
        }
    }
}
