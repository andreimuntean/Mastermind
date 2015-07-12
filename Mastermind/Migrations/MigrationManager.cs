using System.Data.Entity.Migrations;

namespace Mastermind.Migrations
{
    static class MigrationManager
    {
        private static Configuration configuration;

        static MigrationManager()
        {
            configuration = new Configuration();
        }

        public static void Update()
        {
            var migrator = new DbMigrator(configuration);
                
            migrator.Update();
        }
    }
}