namespace AppG2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppG2.Model.AppG2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AppG2.Model.AppG2Context";
        }

        protected override void Seed(AppG2.Model.AppG2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for (int i = 1; i <= 12; i++)
            {
                context.HistoryLearningsDbSet.AddOrUpdate(
                    new Model.HistoryLearning
                    {
                        idHistoryLearning = Guid.NewGuid().ToString(),
                        idStudent = "16T1021221",
                        address = "Cao Bằng",
                        yearFrom = 1989 + i,
                        yearEnd = 1989 + i + 1
                    });
            }
        }
    }
}
