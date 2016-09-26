# Blackjack

## A refactoring kata

The goal of this kata is to go from an untested, procedural codebase to a unit tested, object oriented solution. In order to gain the most value out of this exercise, it is recommended to strive to change no product code without first writing a test around the existing behavior you're changing.

#### Project structure
1. Blackjack - The main program. It does a blackjack.
2. BlackjackTests - Test assembly. Some assembly required.

#### Administering this kata

This kata was originally administered by having small groups (2-3 engineers) independently fork the codebase and pair on a number of randomly issued story cards. Little up-front instruction was given besides to focus on test driving changes and pinning down existing behavior prior to writing new functionality, and to ignore the instinct to rewrite the legacy codebase up-front.

Story cards were issued primarily out of the low value cards. It became clear in the first couple sessions that focusing on changes that did not require designing large new systems allowed the pairs to better focus on the task of pinning behavior and moving towards an object oriented solution.

#### Suggested user stories

When starting the kata, issue random cards from the 1-2 point cards.

* Aces are worth 1 or 11 (1 point)
* Blackjack is worth bonus money (1 point)
* Wagers are paid out 3:2 (1 point)
* Natural blackjack wins even when pushed (1 point)
* User can hit multiple times (2 points)
* Player can pick amount wagered (2 points)
* Double down (3 points)
* Split hand (3 points)
* Insurance (3 points)

See https://en.wikipedia.org/wiki/Blackjack for information on story meanings

#### Bugs

There are a number of issues in the initial untested codebase. It is recommended to track bugs found by the users when reported to you and fixed.

#### Tools
`runcoverage.bat` will run nunit tests and show a report showing your current code coverage

