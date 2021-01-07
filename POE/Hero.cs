using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class Hero: Character
    {
        public Hero(): base()
        {
            X = 0;
            Y = 0;
            Hp = 10;
            MaxHp = 10;
            Dmg = 2;


        }
        public override Movement ReturnMove(Movement move)
        {
            throw new NotImplementedException();
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
