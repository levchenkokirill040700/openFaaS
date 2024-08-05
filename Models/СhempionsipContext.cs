using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    public class СhempionsipContext : DbContext
    {
        public DbSet<Boxer> Boxers { get; set; }
        public DbSet<Chempionsip> Chempionsips { get; set; }
    }
}