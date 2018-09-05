using HaynaMallo.Mayor.Web.Infrastructure.Data.Helpers;
using HaynaMallo.Mayor.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaynaMallo.Mayor.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
