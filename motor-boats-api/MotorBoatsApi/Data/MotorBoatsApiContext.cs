using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MotorBoatsApi.Models;

namespace MotorBoatsApi.Data
{
    public class MotorBoatsApiContext : DbContext
    {
        public MotorBoatsApiContext (DbContextOptions<MotorBoatsApiContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MotorBoatsApi.Models.Team> Team { get; set; }
    }
}
