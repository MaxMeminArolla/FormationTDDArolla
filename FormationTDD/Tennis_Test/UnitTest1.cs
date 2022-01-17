using NUnit.Framework;
using System;
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

        [Test]
        public void should_set_a_point()
        {
            Kata.addPoint(Kata.player1);
            Assert.AreEqual(1, Kata.score[0]);
            Assert.AreEqual(0, Kata.score[1]);
        }

        [Test]
        public void should_display_a_score()
        {
            var result = Kata.score();
            Assert.IsInstanceOf(result, typeof(String));
        }
    }
}