using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class DbMigrator
    {
        private Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah blah...");
        }

    }
}
