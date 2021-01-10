using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class Hero: Character
    {

        public Hero(int x,int y): base("H",0,0)
        {
            X = x;
            Y = y;
            Hp = 10;
            MaxHp = 10;
            Dmg = 2;

        }

        public override Movement ReturnMove(Movement move)
        {
            throw new NotImplementedException();
           // if()
        }
        public override string ToString()
        {
            return "Player stats"
                +" HP: "+Hp+"/"+MaxHp
                +" Damage: "+Dmg
                +"["+X+","+Y+"]";
            
        }
    }
}
