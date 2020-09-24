using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.InterfacesExtensibility.Interfaces;

namespace CSharpDataTypes.InterfacesExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfo($"Migrating started at {DateTime.Now}");
            logger.LogInfo($"Migrating ended at {DateTime.Now}");
        }
    }
}
