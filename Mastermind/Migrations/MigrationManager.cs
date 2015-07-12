using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace Mastermind.Migrations
{
    static class MigrationManager
    {
        private static Configuration configuration;

        static MigrationManager()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var providerName = ConfigurationManager.ConnectionStrings["DefaultConnection"].ProviderName;

            configuration = new Configuration()
            {
                TargetDatabase = new DbConnectionInfo(connectionString, providerName)
            };
        }

        public static void Update()
        {
            var migrator = new DbMigrator(configuration);
                
            migrator.Update();
        }
    }
}