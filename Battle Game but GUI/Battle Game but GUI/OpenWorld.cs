using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Battle_Game_but_GUI
{

    public partial class OpenWorld : Form
    {
        // Initialize Monsters with attributes like health, name, type, attack, etc.
        Monster Goblin = new Monster(1000, "Goblin", "Dark", "Stab", 100, 100);
        Monster Slime = new Monster(1000, "Slime", "Goo", "Smash", 100, 100);
        Monster ElderBlackDragonGod = new Monster(9999, "ElderBlackDragonGod", "Holy", "Obliterate", 9999, 9999);

        // Constructor for OpenWorld form, initializes components.
        public OpenWorld()
        {
            InitializeComponent();
        }

        // Random Number Generator for selecting the monster
        Random getRandom = new Random(); // This will generate random numbers between a given range.

        Monster selectedMonster;  // Holds the currently selected monster to fight.
        Form1 form1 = new Form1();  // Reference to the main form (presumably the start screen).
        //Player player = new Player();  // The player object.


        // Called when the OpenWorld form is loaded.
        private void OpenWorld_Load(object sender, EventArgs e)
        {
            pbPlayerMonster.Image = iLPlayerMonster.Images[Base.chosenMonster]; // Displays the player's monster image

            // Generates a random number to decide which monster to fight.
            int randomMonsterIndex = getRandom.Next(1, 3);

            // Default monster is Goblin.
            selectedMonster = Goblin;

            // Switch case for monster selection.
            switch (randomMonsterIndex)
            {
                case 1:
                    selectedMonster = Goblin; // Goblin selected.
                    break;

                case 2:
                    selectedMonster = Slime; // Slime selected.
                    break;
            }

            // Sets the enemy monster image based on the selected monster.
            pbEnemyMonster.Image = iLEnemyMonster.Images[selectedMonster.getMonster()];
        }

        // Action handler for the "Run" button click, where the player decides to run away.
        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ran away");
            form1.gameRunning = true;  // Game continues running in the main form.
            this.Hide();  // Hides the current form.
            form1.Show();  // Shows the main form (probably the start screen).
        }

        // Function to simulate the monster's attack.
        private void monsterAttack()
        {
            MessageBox.Show($"{selectedMonster.getMonster()} uses {selectedMonster.getAttack()}"); // Shows monster's attack message
        }

        public static int scoreAmount = 0; // Variable to hold the score value.

        // Action handler for the "Attack" button click, where the player attacks the enemy.
        private void btnAttack_Click(object sender, EventArgs e)
        {
            try
            {
                int percentage = getRandom.Next(1, 101); // Generates a random percentage (1 to 100) to determine attack success/failure.

                // 25% chance for the enemy to be the Elder Black Dragon God.
                if (percentage <= 25)
                {
                    selectedMonster = ElderBlackDragonGod;  // If selected, set the enemy to the Elder Black Dragon God.
                    pbEnemyMonster.Image = iLEnemyMonster.Images[selectedMonster.getMonster()]; // Update enemy image
                    MessageBox.Show($"Enemy was actually level 99999 {selectedMonster.getMonster()}"); // Notify the player of the unexpected enemy
                    MessageBox.Show($"Player attacks {selectedMonster.getMonster()}"); // Notify that the player is attacking

                    percentage = getRandom.Next(1, 101);  // Generate another random percentage to check for dodging.

                    if (percentage == 1)
                    {
                        // 1% chance to dodge the attack.
                        MessageBox.Show($"Player dodged {selectedMonster.getMonster()} !!!Victory!!!"); // Player dodges the attack and wins.
                        form1.gameRunning = false; // Game is over, stop the current game.
                        this.Hide(); // Hide the current form.
                        form1.Show(); // Show the main form (start screen).
                    }
                    else if (percentage > 1)
                    {
                        monsterAttack();  // Monster attacks the player.
                        MessageBox.Show($"{selectedMonster.getMonster()} ate the player"); // Monster kills the player.
                        MessageBox.Show($"Player Died to {selectedMonster.getMonster()}"); // Notify the player that they died.
                        scoreAmount = 0; // Resets the players score to 0 points.
                        form1.gameRunning = false; // Game is over, stop the current game.
                        this.Hide(); // Hide the current form.
                        form1.Show(); // Show the main form (start screen).
                    }
                }
                // 75% chance for the enemy to be a normal monster.
                else if (percentage > 25)
                {
                    MessageBox.Show($"Player attacks {selectedMonster.getMonster()}"); // Notify the player is attacking.
                    monsterAttack();  // Monster attacks the player.
                    percentage = getRandom.Next(1, 101);  // Generate another random percentage for the outcome of the attack.

                    // 25% chance for the player to die from the monster's attack.
                    if (percentage <= 25)
                    {
                        MessageBox.Show($"Player Died to {selectedMonster.getMonster()}"); // Notify that the player died.
                        scoreAmount = 0; // Resets the players score to 0 points.
                        form1.gameRunning = false; // End the game.
                        this.Hide(); // Hide the current form.
                        form1.Show(); // Show the main form (start screen).
                    }
                    // 75% chance for the player to successfully kill the monster.
                    else if (percentage > 25)
                    {
                        MessageBox.Show($"Player Successfully Attacks {selectedMonster.getMonster()} and it Dies"); // Notify that the player killed the monster.
                        scoreAmount+= 100; // Increase score by 100 points.
                        MessageBox.Show($"Score: {scoreAmount}"); // Display the player's current score.
                        form1.gameRunning = true; // Continue the game.
                        this.Hide(); // Hide the current form.
                        form1.Show(); // Show the main form (start screen).
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error: During attacking enemy");  // Catch any exceptions and display an error message.
            }
        }
    }
}