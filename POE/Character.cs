using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class Character:Tile
    {
        int Hp;
        int MaxHp;
        int Dmg;
        int weapon;
        string Symbol;

        
        Tile[] CharacterVision;


        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right

        }
        public Character()
        {
            X = 0;
            Y = 0;
            Symbol = "";
            Tile t = new Tile(); 
        }
        public Character(string symbol)
        {
            Tile t = new Tile(X, Y);
            Symbol = symbol;

        }

        public virtual void Attack(/*CharacterTarget*/)
        {
            /* CharacterTarget.  */
            Hp = Hp-Dmg;
        }
        
        public bool IsDead()
        {
            if (Hp == 0)
            {
                return true;
            }
            return false;
        }
        public virtual bool CheckRange(/*CharacterTarget*/)
        {
            int AtkRange = 1 + weapon;
            if (DistanceTo() == AtkRange)
            {
                return true;
            }
            return false;
        }
        private int DistanceTo(/*Target*/)
        {
           /*Target*/ 
        }

    }
}
