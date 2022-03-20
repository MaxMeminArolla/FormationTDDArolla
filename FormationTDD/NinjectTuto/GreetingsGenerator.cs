using System;

namespace NinjectTuto
{
    public class GreetingsGenerator
    {
        private ILogger logger;

        public GreetingsGenerator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Greet(string name)
        {
            logger.Log(String.Format("Greeting {0}", name));
            Console.WriteLine("Hello {0}", name);
        }
    }

    public interface ILogger
    {
        public void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
