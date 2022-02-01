using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoggerConnector
{
    internal class SqlGenerator : NpgsqlMigrationSqlGenerator
    {
        private readonly string[] systemColumnNames = { "oid", "tableoid", "xmin", "cmin", "xmax", "cmax", "ctid" };

        protected override void Convert(CreateTableOperation createTableOperation)
        {
            var systemColumns = createTableOperation.Columns.Where(x => systemColumnNames.Contains(x.Name)).ToArray();
            foreach (var systemColumn in systemColumns)
                createTableOperation.Columns.Remove(systemColumn);
            base.Convert(createTableOperation);
        }
    }
}
