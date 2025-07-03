# fighterJetShootingGame
Project Description
This project is a basic 2D space shooter game developed using C# and Windows Forms. The player controls a spaceship (represented by player) at the bottom of the screen, which can move left and right. Enemies (represented by enemyOne, enemyTwo, and enemyThree) descend from the top of the screen. The objective of the game is for the player to shoot down the incoming enemies using a bullet.

The game features:

Player Movement: The player's spaceship can move horizontally using the Left and Right arrow keys.

Shooting Mechanism: The player can fire a single bullet by pressing the Spacebar. The bullet travels upwards, and upon hitting an enemy, the enemy is reset to a new random position at the top of the screen, and the player's score increases.

Enemy Movement: Three enemy objects continuously move downwards. If any enemy reaches the bottom of the screen, the game ends.

Scoring System: The player earns points for each enemy shot down.

Difficulty Scaling: After reaching a score of 10, the enemy speed increases, making the game more challenging.

Game Over and Reset: The game ends if an enemy passes the player's boundary. The player can restart the game by pressing the Enter key.
