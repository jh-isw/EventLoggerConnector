using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoggerConnector
{
    [DbConfigurationType(typeof(EventsDbConfiguration))]
    public class EventsDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message>().HasKey(m => new { m.TimeRaised, m.EventClass, m.EventId, m.SourceId });
        }
    }
}
