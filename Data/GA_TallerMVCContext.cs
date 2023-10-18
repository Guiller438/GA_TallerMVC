using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GA_TallerMVC.Models;

namespace GA_TallerMVC.Data
{
    public class GA_TallerMVCContext : DbContext
    {
        public GA_TallerMVCContext (DbContextOptions<GA_TallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<GA_TallerMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
