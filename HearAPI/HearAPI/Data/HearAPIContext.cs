using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HearAPI.Models;

namespace HearAPI.Data
{
    public class HearAPIContext : DbContext
    {
        public HearAPIContext (DbContextOptions<HearAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HearAPI.Models.User> User { get; set; } = default!;
    }
}
