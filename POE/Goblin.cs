using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    public class Goblin : Enemy
    {
        private TileType ClassType;
       
        public Goblin() 
        {
            Symbol = "GOB";
            ClassType = TileType.Enemy;
            MaxHp = 10;
            Dmg = 1;
            X = 0;
            Y = 0;
        }
        public override Movement ReturnMove(Movement move)
        {
            throw new NotImplementedException();

        }
    }
}
