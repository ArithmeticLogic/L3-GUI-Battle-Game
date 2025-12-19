using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Game_but_GUI
{
    internal class Player : Monster
    {
        private string playerMonster;

        public Player(int healthC, string monsterC, string attributeC, string attackC, int attackDamageC, int defenceC) : base(healthC, monsterC, attributeC, attackC, attackDamageC, defenceC) {}

        // Constructor to initialize the player
        public Player() { }

        // Setter for players monster
        public void setPlayerMonster(string name)
        {
            playerMonster = name; // Set the players monster name
        }

        // Getter for players monster
        public string getPlayerMonster()
        {
            return playerMonster; // Return the name of the players monster
        }
    }
}