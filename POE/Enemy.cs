using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    public abstract class Enemy:Character
    {
        protected Random Obj= new Random();


        public Enemy(string symbol,int x,int y, int dmg) : base("", 0, 0)
        {
              
            X = x;
            Y = y;
            Symbol = symbol;
            Dmg = dmg;
        }
        public override string ToString()
        {
            return Symbol+"at ["+X+","+Y+"("+Dmg+"DMG)";
        }
    }
}
