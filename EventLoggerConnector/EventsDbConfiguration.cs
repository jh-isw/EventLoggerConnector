using System.Data.Entity;

namespace EventLoggerConnector
{
    internal class EventsDbConfiguration : DbConfiguration
    {
        public EventsDbConfiguration()
        {
            SetMigrationSqlGenerator("Npgsql", () => new SqlGenerator());
        }
    }
}