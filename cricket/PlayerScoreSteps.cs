using CricketGame;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace cricket
{
    [Binding]
    public class PlayerScoreSteps
    {

        private Cricket _game;

        [Given(@"Game Started")]
        public void GivenGameStarted()
        {
            _game = new Cricket();
        }

        [When(@"player (.*) starts a game of cicket")]
        [Given(@"player (.*) has started a game of cricket")]
       public void WhenPlayerHasStartAGameOfCicket(int playerId)
        {
       
            _game.StartPlay(playerId-1);
        }

        [Given(@"player (.*) has scored (.*) runs")]
        [When(@"player (.*) scores (.*) runs")]
        [Given(@"player (.*) scores (.*) runs")]
        public void WhenPlayerScoresRuns(int playerId,int score)
        {
            _game.UpdateScore(playerId-1,score);
        }
        [Given(@"Player (.*) gets out")]
        public void WhenPlayerGetsOut(int playerId)
        {
            
            _game.UpdatePlayerStatus(playerId-1);
        }

        [Then(@"the player (.*) score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int playerId,int score)
        {
            _game.GetScore(playerId-1).Should().Be(score);
        }
        [Then(@"player (.*) is the winner of the game")]
        public void ThenPlayerIsTheWinnerOfTheGame(int playerID)
        {
            _game.Winner().Should().Be(playerID);
        }


        [Then(@"The Game is Tied")]
        public void ThenTheGameIsTied()
        {
            _game.Winner().Should().Be(0);
        }

    }
}
