Feature: MultiPlayer
	In order to enjoy a game of cricket with MultiPlayers
	As a Player
	I want to be told Both players scores

@mytag
Scenario:  player 1 should be winner if player 1 scores more then player 2
Given Game Started
Given player 1 has started a game of cricket
And  player 1 scores 3 runs
And  player 1 scores 4 runs
And  player 1 scores 2 runs
And  player 1 scores 6 runs
And  player 1 scores 2 runs
And  player 1 scores 6 runs
And  Player 1 gets out
Given player 2 has started a game of cricket
And  player 2 scores 3 runs
And  player 2 scores 4 runs
And  player 2 scores 2 runs
And  Player 2 gets out
Then player 1 is the winner of the game

Scenario:  Game should be tie if both players has same score
Given Game Started
Given player 1 has started a game of cricket
And  player 1 scores 3 runs
And  player 1 scores 4 runs
And  player 1 scores 2 runs
And  player 1 scores 6 runs
And  player 1 scores 2 runs
And  player 1 scores 6 runs
And  Player 1 gets out
Given player 2 has started a game of cricket
And  player 2 scores 3 runs
And  player 2 scores 4 runs
And  player 2 scores 2 runs
And  player 2 scores 6 runs
And  player 2 scores 2 runs
And  player 2 scores 6 runs
And  Player 2 gets out
Then The Game is Tied