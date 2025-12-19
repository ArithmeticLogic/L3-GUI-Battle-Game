using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Game_but_GUI
{
    // This class represents the "Base" form, where the player selects their monster.
    public partial class Base : Form
    {
        // Constructor to initialize the form
        public Base()
        {
            InitializeComponent(); // Initializes the components of the Base form
        }
        private void Base_Load(object sender, EventArgs e)
        {
            btnChooseMonster1.Image = iLPlayerMonster.Images["Igris"]; // Setting the image for the first button as Igris
            btnChooseMonster2.Image = iLPlayerMonster.Images["Aqua"]; // Setting the image for the second button as Aqua
        }

        // Creating instances of the Monster class
        Monster Igris = new Monster(100, "Igris", "Fire", "Volcano", 1, 1); // Igris monster
        Monster Aqua = new Monster(100, "Aqua", "Water", "Tsunami", 1, 1); // Aqua monster

        Player player = new Player(); // Creating an instance of the Player class

        public static string chosenMonster = "Igris"; // A string to store the selected monster's name, default is "igris"

        // Method to choose a monster based on the player's selection
        public void chooseAMonster()
        {
            Form1 form1 = new Form1(); // Creating a new instance of the Form1 class (main menu)

            try
            {
                // If the chosen monster is "igris", set the player's monster to Igris
                if (chosenMonster == "Igris")
                {
                    player.setPlayerMonster("Igris"); // Set player monster to Igris
                }
                // If the chosen monster is "aqua", set the player's monster to Aqua
                else if (chosenMonster == "Aqua")
                {
                    player.setPlayerMonster("Aqua"); // Set player monster to Aqua
                }
                // If the user selected "cancel", display a message that no monster was chosen
                else if (chosenMonster == "cancel")
                {
                    MessageBox.Show("No Monster Chosen"); // Inform the user that no monster was chosen
                }
                // If the user entered an invalid choice, display an error message
                else
                {
                    MessageBox.Show("Invalid monster"); // Display an error message for invalid monster choice
                }
            }
            catch
            {
                // Catch block to handle any errors that may occur during the monster selection process
                MessageBox.Show("Error: During choosing monster"); // Display an error message if an error occurs
            }

            // Display the monster currently chosen by the player
            MessageBox.Show($"You currently have {player.getPlayerMonster()}"); // Output the chosen monster

            form1.gameRunning = true;
            this.Hide(); // Hide the current Base form
            form1.Show(); // Show the Form1 (main menu) form after the monster selection
        }

        // Event handler for when the "Choose Igris" button is clicked
        private void btnChooseMonster1_Click(object sender, EventArgs e)
        {
            chosenMonster = "Igris"; // Set the chosen monster to "igris"
            chooseAMonster(); // Call the method to process the monster choice
        }

        // Event handler for when the "Choose Aqua" button is clicked
        private void btnChooseMonster2_Click(object sender, EventArgs e)
        {
            chosenMonster = "Aqua"; // Set the chosen monster to "aqua"

            chooseAMonster(); // Call the method to process the monster choice
        }

        // Event handler for when the "Cancel Monster Select" button is clicked
        private void btnCancelMonsterSelect_Click(object sender, EventArgs e)
        {
            chosenMonster = "cancel"; // Set the chosen monster to "cancel"
            chooseAMonster(); // Call the method to process the cancellation
        }
    }
}