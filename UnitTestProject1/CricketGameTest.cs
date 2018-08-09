using System;
using CricketGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CricketGameTest
    {
        [TestMethod]
        public void PlayerStartPlay()
        {
            var game = new Cricket();
            game.StartPlay(0);
            Assert.AreEqual(game.GetScore(0),0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0,4);
            Assert.AreEqual(game.GetScore(0), 4);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0,8);
            Assert.AreEqual(game.GetScore(0), 0);
        }
        [TestMethod]
        public void Score_ValidRuns_MultipltTimes_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0, 4);
            game.UpdateScore(0, 3);
            Assert.AreEqual(game.GetScore(0),7);
        }
        [TestMethod]
        public void Score_InvalidRuns_PlayerOut_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0,4);
            game.UpdatePlayerStatus(0);
            game.UpdateScore(0, 4);
            Assert.AreEqual(game.GetScore(0),4);
        }

        [TestMethod]

        public void Winner_Of_The_Game()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0, 6);
            game.UpdateScore(0, 6);
            game.UpdateScore(0, 6);
            game.UpdatePlayerStatus(0);
            game.StartPlay(1);
            game.UpdateScore(1, 2);
            game.UpdateScore(1, 3);
            game.UpdateScore(1, 4);
            game.UpdatePlayerStatus(1);
            Assert.AreEqual(game.Winner(),1);
        }

        [TestMethod]
        public void Match_Tie()
        {
            var game = new Cricket();
            game.StartPlay(0);
            game.UpdateScore(0, 6);
            game.UpdateScore(0, 6);
            game.UpdateScore(0, 6);
            game.UpdatePlayerStatus(0);
            game.StartPlay(1);
            game.UpdateScore(1, 6);
            game.UpdateScore(1, 6);
            game.UpdateScore(1, 6);
            game.UpdatePlayerStatus(1);
            Assert.AreEqual(game.Winner(), 0);
        }
    }
}
