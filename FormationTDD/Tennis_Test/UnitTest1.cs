using NUnit.Framework;
using Tennis;

namespace Tennis_Test
{
    public class Tests
    {
        [SetUp]
        public void init()
        {
            Kata.init("Maurice", "Jean Eudes");
        }

        [Test]
        public void should_game_initialized()
        {
            Assert.IsNotNull(Kata.player1);
            Assert.IsNotNull(Kata.player2);
            Assert.AreEqual("Maurice", Kata.player1);
            Assert.AreEqual("Jean Eudes", Kata.player2);
        }
    }
}