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
            Assert.AreEqual(1, Kata.scoring[0]);
            Assert.AreEqual(0, Kata.scoring[1]);
        }

        [Test]
        public void should_display_a_score()
        {
            var result = Kata.score();
            Assert.IsInstanceOf(typeof(String), result);
            Assert.AreEqual("score:Love-Love", result);
        }

        [Test]
        public void should_display_a_score_after_a_point()
        {
            Kata.addPoint(Kata.player1);
            var result = Kata.score();
            Assert.IsInstanceOf(typeof(String), result);
            Assert.AreEqual("score:Fifteen-Love", result);
        }

        [Test]
        public void should_display_a_score_after_two_points()
        {
            Kata.addPoint(Kata.player1);
            Kata.addPoint(Kata.player1);
            var result = Kata.score();
            Assert.AreEqual("score:Thirty-Love", result);
        }

        [Test]
        public void should_display_a_score_after_three_points()
        {
            Kata.addPoint(Kata.player1);
            Kata.addPoint(Kata.player1);
            var result = Kata.score();
            Assert.AreEqual("score:Forty-Love", result);
        }
    }
}