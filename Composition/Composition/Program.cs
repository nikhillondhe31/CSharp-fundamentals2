using System;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installery(logger);

            dbmigrator.Migrate();
            installer.Install();   
        }
    }
}
