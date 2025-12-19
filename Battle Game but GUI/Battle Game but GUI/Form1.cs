using System.Diagnostics; // Importing the necessary library for debugging
using System.Numerics; // Importing the System.Numerics namespace (though not used in the code provided)
using Microsoft.VisualBasic.ApplicationServices; // Importing for application services (though not used in the code provided)

namespace Battle_Game_but_GUI
{
    // Main form class for the Battle Game
    public partial class Form1 : Form
    {
        // Constructor to initialize the form
        public Form1()
        {
            InitializeComponent(); // Initializes the components of the form
        }

        public bool gameRunning = false; // A flag to track whether the game is running or not

        // Event handler that is triggered when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            //Player player = new Player(); // Referencing to player class
            GameRunning(); // Calls GameRunning method to update the UI based on the game state
            //player.setPlayerMonster("Igris"); // Set player monster to Igris
        }

        // Method to update the UI based on whether the game is running
        public void GameRunning()
        {
            // If the game is running, show the appropriate buttons and hide others
            if (gameRunning)
            {
                startGameBtn.Visible = false; // Hide the 'Start Game' button
                openWorldBtn.Visible = true;  // Show the 'Open World' button
                baseBtn.Visible = true;       // Show the 'Base' button
            }
            // If the game is not running, show the 'Start Game' button and hide others
            else if (!gameRunning)
            {
                startGameBtn.Visible = true;  // Show the 'Start Game' button
                openWorldBtn.Visible = false; // Hide the 'Open World' button
                baseBtn.Visible = false;      // Hide the 'Base' button
            }
        }

        string areaType; // A variable to hold the type of area selected by the user

        // Method to choose an area based on user selection (Open World or Base)
        public void chooseAnArea()
        {
            Base Base = new Base(); // Create a new instance of the 'Base' class
            OpenWorld openWorld = new OpenWorld(); // Create a new instance of the 'OpenWorld' class

            try
            {
                // Check if the user selected "openworld"
                if (areaType == "openworld")
                {
                    this.Hide(); // Hide the current form (Main Menu)
                    openWorld.Show(); // Show the Open World form
                }
                // Check if the user selected "base"
                else if (areaType == "base")
                {
                    this.Hide(); // Hide the current form (Main Menu)
                    Base.Show(); // Show the Base form
                }
            }
            catch
            {
                // If an error occurs, show a message box with an error message
                MessageBox.Show("Error: Invalid area"); // In case of an error, print an error message in the debug output
            }
        }

        // Event handler for when the 'Start Game' button is clicked
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            gameRunning = true; // Set the game state to running
            GameRunning(); // Update the UI based on the game state
        }

        // Event handler for when the 'Base' button is clicked
        private void baseBtn_Click(object sender, EventArgs e)
        {
            areaType = "base"; // Set the area type to "base"
            chooseAnArea(); // Call the method to navigate to the selected area
        }

        // Event handler for when the 'Open World' button is clicked
        private void openWorldBtn_Click(object sender, EventArgs e)
        {
            areaType = "openworld"; // Set the area type to "openworld"
            chooseAnArea(); // Call the method to navigate to the selected area
        }
    }
}