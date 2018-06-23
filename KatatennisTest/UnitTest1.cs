using System;
using Katatennis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KatatennisTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void Playerhave0Point()
        {
            var player = new Player("Moises");
            Assert.AreEqual(0, player.Score);

        }

        [TestMethod]
        public void Playerhave1Point()
        {
            var player = new Player("Moises");
            player.WinPoint();
            Assert.AreEqual(1, player.Score);

        }
        [TestMethod]
        public void Playerhave2Point()
        {
            var player = new Player("Moises");
            player.WinPoint();
            player.WinPoint();
            Assert.AreEqual(2, player.Score);

        }
        [TestMethod]
        public void GameCanRetrunBothPlayerScoreLove()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player,player2);
            var expected = "love-love";
            var actual = game.GetScore();
         
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerOne15()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "fifteen-love";
            player.WinPoint();
            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerOnethirty()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "fifteen-love";
            player.WinPoint();
            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerOnehasfortyAndPlayerTwoHasThirty()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "forty-thirty";
            player.WinPoint();
            player.WinPoint();
            player.WinPoint();
       

            player2.WinPoint();
            player2.WinPoint();
            
            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerOneWin()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "Moises won";
            player.WinPoint();
            player.WinPoint();
            player.WinPoint();
            player.WinPoint();
            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerTwoWin()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "Maria won";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GameCanReturnbothPlayerDeuce()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "deuce";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();

            player.WinPoint();
            player.WinPoint();
            player.WinPoint();


            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerOneHasAdvantage()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "Moises has the advantage";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();

            player.WinPoint();
            player.WinPoint();
            player.WinPoint();

            player.WinPoint();

            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GameCanReturnPlayerTwoHasAdvantage()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "Maria has the advantage";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player.WinPoint();
            player.WinPoint();
            player.WinPoint();

           

            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerTwoWinGame()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "Maria won";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            player.WinPoint();
            player.WinPoint();
            player.WinPoint();



            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GameCanReturnPlayerTwoafterhasAdvantageHasNowDeuce()
        {
            var player = new Player("Moises");
            var player2 = new Player("Maria");
            var game = new Game(player, player2);
            var expected = "deuce";
            player2.WinPoint();
            player2.WinPoint();
            player2.WinPoint();
            
            

            player.WinPoint();
            player.WinPoint();
            player.WinPoint();

            player2.WinPoint();

            player.WinPoint();



            var actual = game.GetScore();

            Assert.AreEqual(expected, actual);

        }
    }
}
