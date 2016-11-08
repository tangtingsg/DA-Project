using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DA.Core.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DA.Core {
    public class SystemContext : DbContext {
        public SystemContext():base("DymonAsiaDb") { }

        public DbSet<Customer> Customers { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            
        }
    }
}