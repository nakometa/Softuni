using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public static class DateModifier
    {
        public static int DaysDifference(string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.Parse(dateOne);
            DateTime secondDate = DateTime.Parse(dateTwo);

            TimeSpan diff = firstDate - secondDate;
            return diff.Days;
        }
    }
}
