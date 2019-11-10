using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models
{
    public class WebDataContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public WebDataContext(DbContextOptions<WebDataContext> options) : base(options)
        {

        }
    }
}
