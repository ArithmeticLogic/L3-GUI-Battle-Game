using System;

namespace Battle_Game_but_GUI
{
    internal class Monster
    {
        private string monster, attribute, attack;
        private int attackDamage, defence, health;

        // Constructor to initialize the monster
        public Monster(int healthC, string monsterC, string attributeC, string attackC, int attackDamageC, int defenceC)
        {
            health = healthC;
            monster = monsterC;
            attribute = attributeC;
            attack = attackC;
            attackDamage = attackDamageC;
            defence = defenceC;
        }

        public Monster() { }

        // Getter for health
        public int getHealth()
        {
            return health;
        }

        // Getter for monster
        public string getMonster()
        {
            return monster;
        }

        // Getter for attack
        public string getAttack()
        {
            return attack;
        }

        //Monster Igris = new Monster(100, "Igris", "Fire", "Volcano", 1, 1);
        //Monster Aqua = new Monster(100, "Aqua", "Water", "Tsunarmi", 1, 1);
        //Monster Goblin = new Monster(1000, "Goblin", "Dark", "Stab", 100, 100);
        //Monster Slime = new Monster(1000, "Slime", "Goo", "Smash", 100, 100);
        //Monster ElderBlackDragonGod = new Monster(9999, "ElderBlackDragonGod", "Holy", "Obliterate", 9999, 9999);
    }
}