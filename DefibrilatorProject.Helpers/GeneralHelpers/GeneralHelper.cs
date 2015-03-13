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
            var correctDate = date.ToString(CultureInfo.InvariantCulture);
            if (correctDate.Contains("/")) 
            {
                var datePartsTmp = correctDate.Split(Convert.ToChar(" "));
                var dateParts = datePartsTmp[0].Split(Convert.ToChar("/"));
                correctDate = dateParts[2] + "-" + dateParts[0] + "-" + dateParts[1];
            }
            else
            {
                var datePartsTmp = correctDate.Split(Convert.ToChar(" "));
                var dateParts = datePartsTmp[0].Split(Convert.ToChar("."));
                correctDate = dateParts[2] + "-" + dateParts[1] + "-" + dateParts[0];
            }
            return Convert.ToDateTime(correctDate);
        }
    }
}
