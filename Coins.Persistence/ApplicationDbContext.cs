using Coins.Models;
using Coins.Persistence.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("CoinsConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CoinsMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
