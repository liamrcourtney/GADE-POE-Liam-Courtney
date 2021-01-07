using System;
using System.Collections.Generic;
using System.Text;


namespace POE
{
    abstract class Character:Tile
    {
        public int Hp;
        public int MaxHp;
        public int Dmg;
        public int weapon;
        public int CharDistance;
        public int Target;
        public double Distance;
        public string Symbol;



        Tile[] CharacterVision;


        public enum Movement
        {
            NoMovement = 0,
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4

        }
        public Character()
        {
            X = 0;
            Y = 0;
            Symbol = "";
            
        }
        public Character(string symbol,int x, int y)
        {
            X = x;
            Y = y;
            Symbol = symbol;

        }

        public virtual void Attack(Character Target)
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
        public virtual bool CheckRange(Character Target)
        {

            int AtkRange = weapon + 1;
            AtkRange = Target;
            
            if (DistanceTo(target) == AtkRange)
            {
                return true;
            }
            return false;

        }
        private int DistanceTo(int target)
        {
            Distance = Math.Sqrt((X - X) ^ 2 + (Y - Y) ^ 2);
            Distance = target;
            
        }
        public void Move(Movement Move)
        {
            if (Move == Movement.NoMovement)
            {
                X =X + 0;
                Y =Y + 0;
            }
            if (Move == Movement.Up)
            {
                X = X + 0;
                Y = Y + 1;
            }
            if (Move == Movement.Down)
            {
                X = X + 0;
                Y = Y - 1;
            }
            if (Move == Movement.Left)
            {
                X = X + 1;
                Y = Y + 0;
            }
            if (Move == Movement.Right)
            {
                X = X - 1;
                Y = Y + 0;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0)
        {

        }
        
        public abstract override string ToString();


    }

}
