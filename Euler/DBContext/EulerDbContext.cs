using Euler.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.DBContext
{
    public class EulerDbContext : IdentityDbContext<User>
    {
        public EulerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Problem> Problems { get; set; }

    }
}
