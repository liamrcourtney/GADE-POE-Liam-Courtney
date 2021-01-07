using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    public class Goblin : Enemy
    {
       
        
       
        public Goblin() 
        {
            Symbol = "GOB";
            MaxHp = 10;
            Dmg = 1;
            X = 0;
            Y = 0;
        }
        public override Movement ReturnMove(Movement move)
        {
            //throw new NotImplementedException();
            
            
            switch (Obj.Next(0, 5))
            {
                case 0 :
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
