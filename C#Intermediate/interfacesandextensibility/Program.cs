using System;


namespace Extensibility
{
  public class FileLogger : ILogger
  {
    private readonly string _path;

    public FileLogger(string path)
    {
      _path = path;
    }

    public void LogError(string message)
    {
      LogError(message, "ERROR");
    }

    public void LogInfo(string message)
    {
      LogInfo(message, "INFO");
    }

    private void Log(string message, string messageType)
    {
      using (var streamWriter = new StreamWriter(_path, true))
      {
        streamWriter.WriteLine(messageType + ": " + message);
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator(new ConsoleLogger());
        dbMigrator.Migrate();
    }
  }
}
