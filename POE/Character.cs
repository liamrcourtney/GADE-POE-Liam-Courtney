using System;
using System.Collections.Generic;
using System.Text;


namespace POE
{
    public abstract class Character:Tile
    {
        protected int Hp;
        protected int MaxHp;
        protected int Dmg;
        public int weapon;
        public int CharDistance;
        public int Target;
        public double Distance;
        public string Symbol;
        public double a = 1.0;



        public Tile[] CharacterVision = new Tile[4] /*{ (X + 0, Y + 1), (X + 0, Y - 1), (X + 1, Y + 0), (X - 1, Y + 0) }*/;

        //public static Vision()
        //{

        //}
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
                        
            if (DistanceTo(Target) == AtkRange)
            {
                return true;
            }
            return false;

        }
        private int DistanceTo(Character Target) 
        {
            
            if(Distance >a)
            {
                return (int)(Distance = Math.Sqrt((X - X) ^ 2 + (Y - Y) ^ 2));
            }
            return (int)(Distance = Math.Sqrt((X - X) ^ 2 + (Y - Y) ^ 2));



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

        public abstract Movement ReturnMove(Movement move = 0);
     

    public abstract override string ToString();

       
    }

}
