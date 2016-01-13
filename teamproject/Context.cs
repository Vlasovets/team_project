using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace teamproject
{
    class Context:DbContext
    {
        public Context() : base("localsql2012") { }

        public DbSet<Cup> Cup { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
