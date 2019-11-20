using System;


namespace Extensibility
{
  class Program
  {
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator(new ConsoleLogger());
        dbMigrator.Migrate();
    }
  }
}
