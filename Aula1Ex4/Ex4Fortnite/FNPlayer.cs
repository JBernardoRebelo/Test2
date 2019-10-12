using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4Fortnite
{
    public class FNPlayer
    {
        // Player's HP, defining max and min
        public int Hp { get; set; }

        // Skin
        public string Skin { get; set; }

        // Variables
        private static int _maxHp = 100;

        // Default constructor
        public FNPlayer()
        {
            Hp = _maxHp;
            Skin = "Default";
        }

        // Custom constructor
        public FNPlayer(string skin, int hp)
        {
            Skin = skin;

            // Def hp values
            if (hp > _maxHp) Hp = _maxHp;
            else if (hp < 0) Hp = 0;
            else Hp = hp;
        }

        // Recieves damage
        public void TakeDamage(int dmg)
        {
            if(Hp > 0) Hp -= dmg;
        }

        // Heals
        public void Heal(int heal)
        {
            if(Hp >= 100 && Hp > 0) Hp += heal;
        }

        // Heals
        public void Heal()
        {
            if (Hp >= 100 && Hp > 0) Hp += 20;
        }

        // Shoots another player
        public void Shoot(FNPlayer other)
        {
            if(Hp <=100 && Hp > 0) other.TakeDamage(15);    
        }
    }
}
