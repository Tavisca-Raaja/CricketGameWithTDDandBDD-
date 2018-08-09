Feature: PlayerScore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: player 1 score is zero when game started
Given Game Started
	When player 1 starts a game of cicket
	Then the player 1 score should be 0
	
Scenario: player 1 should be able to score runs
Given Game Started
	Given  player 1 has started a game of cricket
	When  player 1 scores 4 runs
	Then  the player 1 score should be 4

Scenario: player 1 should be able to score runs multiple times
Given Game Started
	Given  player 1 has started a game of cricket
	Given player 1  has scored 4 runs
	When  player 1 scores 3 runs
	Then  the player 1 score should be 7
	
Scenario: Player 1 should not be able to score runs after getting out
Given Game Started
Given  player 1 has started a game of cricket
Given player 1 has scored 4 runs
Given Player 1 gets out
When player 1 scores 3 runs
Then the player 1 score should be 4