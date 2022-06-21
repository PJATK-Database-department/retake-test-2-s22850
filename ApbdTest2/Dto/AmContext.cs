using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Dto
{
    public class AmContext : DbContext
    {
        public AmContext() { }

        // public AmContext(DbContextOptionsBuilder<DbContext> options) : base(options) { }

        public virtual DbSet<Firefighter> Firefighters { get; set; }
        public virtual DbSet<Firefighter_Action> Firefighter_Actions { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Firetruck_Action> Firetruck_Actions { get; set; }
        public virtual DbSet<Firetruck> Firetrucks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Model;


        }





    }
}
