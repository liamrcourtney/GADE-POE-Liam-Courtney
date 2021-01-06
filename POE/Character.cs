using System;
using System.Collections.Generic;
using System.Text;


namespace POE
{
    class Character:Tile
    {
        public int Hp;
        public int MaxHp;
        public int Dmg;
        public int weapon;
        public int CharDistance;
        public int Target;
        public Tile CharTarg = new Tile();
        public Character CharDis = new Character();
        public double Distance;
        public string Symbol;
        

        
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

        public virtual void Attack(CharTarget)
        {
             
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
        public virtual bool CheckRange(CharTarg)
        {
            int AtkRange = 1 + weapon;
            if (DistanceTo(Target) == AtkRange)
            {
                return true;
            }
            return false;
        }
        private int DistanceTo(target)
        {
            Distance = Math.Sqrt((CharTarg.X - CharDis.X) ^ 2 + (CharTarg.Y - CharDis.Y) ^ 2);
        }

    }
}
