using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GGStore.Models
{
    public partial class GGStore : DbContext
    {
        public GGStore()
            : base("name=GGStore")
        {
        }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerType> ManagerTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
