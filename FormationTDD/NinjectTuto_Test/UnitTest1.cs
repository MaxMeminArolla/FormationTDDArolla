using Ninject;
using NinjectTuto;
using NUnit.Framework;
using System;
using System.IO;

namespace NinjectTuto_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_diplay_a_log_in_console()
        {
            using (var kernel = new StandardKernel())
            {
                kernel.Bind<ILogger>().To<ConsoleLogger>();
                var generator = kernel.Get<GreetingsGenerator>();
                
                using (StringWriter sw = new())
                {
                    Console.SetOut(sw);

                    generator.Greet($"John Doe");

                    string expected = $"Greeting John Doe{Environment.NewLine}Hello John Doe{Environment.NewLine}";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }     
        }
    }
}