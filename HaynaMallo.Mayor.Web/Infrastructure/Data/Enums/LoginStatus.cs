using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaynaMallo.Mayor.Web.Infrastructure.Data.Enums
{
    public enum LoginStatus
    {
        Unverified,
        Active,
        Locked,
        NeedsToChangePassword
    }
}
