using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseDemo.API.Utils
{
    public static class Common
    {
        public static DateTime TimeStampToDateTime(this double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
