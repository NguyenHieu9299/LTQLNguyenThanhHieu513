using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050513.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
