namespace Extensibility
{
  public class ConsoleLogger : ILogger
  {
    public void LogError(string message)
    {
      ConsoleLogger.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(message);
    }
    public void LogInfo(string message)
    {
      ConsoleLogger.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(message);
    }
  }
}