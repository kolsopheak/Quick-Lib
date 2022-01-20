using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Lib
{
    public static class SystemConfig
    {
        public static int TokenExiration = 10;
        public static string JwtSecret = "vpwmkcyizhrgjfuvslvdklbbtaxvdkei";
        public static string DefaultConnection = "Server=localhost;Database=DBTestx;Trusted_Connection=True;MultipleActiveResultSets=true";
    }
}
