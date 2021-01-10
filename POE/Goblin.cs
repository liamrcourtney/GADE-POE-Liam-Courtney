using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    public class Goblin : Enemy
    {
       
        
       
        public Goblin(int x,int y):base("G",0,0,1) 
        {
            Symbol = "G";
            MaxHp = 10;
            Dmg = 1;
            X = x;
            Y = y;
        }
        public override Movement ReturnMove(Movement move)
        {
            //throw new NotImplementedException();


            switch (Obj.Next(0, 5))
            {
                case 0:
                    X = X + 0;
                    Y = Y + 0;
                    break;
                case 1:
                    X = X + 0;
                    Y = Y + 1;

                    break;
                case 2:
                    X = X + 0;
                    Y = Y - 1;
                    break;
                case 3:
                    X = X + 1;
                    Y = Y + 0;
                    break;
                case 4:
                    X = X - 1;
                    Y = Y + 0;
                    break;
            }
            return move;
            
        }
    }
}
