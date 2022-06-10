
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateTime Date { get; set; }

        public double CalculateDiffereceBetwwenDates(string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);

            var total = (start - end).TotalDays;

            return Math.Abs(total);
        }
    }
}
