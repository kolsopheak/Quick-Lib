using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Lib
{
    public sealed class Clock
    {
        public static DateTime DateTimeNow(string timezoneId)
        {
            try
            {
                DateTime now = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById(timezoneId));
                return now;
            }
            catch (System.IO.IOException e)
            {
                throw new Exception(e.Message);
            }

        }

        public static DateTime DateTimeNow()
        {
            try
            {
                DateTime now = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));
                return now;
            }
            catch (System.IO.IOException e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
