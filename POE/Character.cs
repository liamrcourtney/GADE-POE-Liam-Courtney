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
        protected int V = 0;





        public Tile[] CharacterVision = { };

        
        public enum Movement
        {
            NoMovement = 0,
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4

        }

        public Movement movement;

        public Movement Moove
        {
            get
            {
                return movement;
            }
            set
            {
                movement = value;
            }
        }
       
        public Character(string symbol,int x, int y):base(0,0)
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
            
            if (Moove == Movement.NoMovement)
            {
                X =X + 0;
                Y =Y + 0;

            }
            if (Moove == Movement.Up)
            {
                Y = Y + 1;
            }
            if (Moove == Movement.Down)
            {
                Y = Y - 1;
            }
            if (Moove == Movement.Left)
            {
                X = X + 1;
            }
            if (Moove == Movement.Right)
            {
                X = X - 1;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);
     

    public abstract override string ToString();

       
    }

}
