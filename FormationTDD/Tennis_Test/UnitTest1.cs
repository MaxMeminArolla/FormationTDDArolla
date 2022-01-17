using NUnit.Framework;

namespace Tennis_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_game_initialized()
        {
            Kata.init("Maurice", "Jean Eudes");
        }
    }
}