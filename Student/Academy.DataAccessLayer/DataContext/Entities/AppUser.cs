using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccessLayer.DataContext.Entities
{
    public class AppUser :IdentityUser
    {
        public required string FullName { get; set; }
    }
}
