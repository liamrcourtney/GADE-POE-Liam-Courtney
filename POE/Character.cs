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
            Tile t = new Tile(); 
        }
        public Character(string symbol)
        {
            Tile t = new Tile(X, Y);
            Symbol = symbol;

        }

        public virtual void Attack(CharTarg)
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
        public virtual bool CheckRange(int CharTarg)
        {

            int AtkRange = weapon + 1;
            AtkRange = CharTarg;
            
            if (DistanceTo(Target) == AtkRange)
            {
                return true;
            }
            return false;

        }
        private int DistanceTo(int Targ)
        {
            Distance = Math.Sqrt((CharTarg.X - CharDis.X) ^ 2 + (CharTarg.Y - CharDis.Y) ^ 2);
            Distance = Targ;
            
        }
        public void Move(Movement Move)
        {
            if (Move == Movement.NoMovement)
            {
                CharDis.X = CharDis.X + 0;
                CharDis.Y = CharDis.Y + 0;
            }
            if (Move == Movement.Up)
            {
                CharDis.X = CharDis.X + 0;
                CharDis.Y = CharDis.Y + 1;
            }
            if (Move == Movement.Down)
            {
                CharDis.X = CharDis.X + 0;
                CharDis.Y = CharDis.Y - 1;
            }
            if (Move == Movement.Left)
            {
                CharDis.X = CharDis.X + 1;
                CharDis.Y = CharDis.Y + 0;
            }
            if (Move == Movement.Right)
            {
                CharDis.X = CharDis.X - 1;
                CharDis.Y = CharDis.Y + 0;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0)
        {

        }
        public abstract override string ToString();


    }

}
