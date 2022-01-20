using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Lib
{
    public enum ReasonRevoke
    {
        ReplaceNewToken = 1,
        Revoke,
        Logout,
        ResuseToken
    }
}
