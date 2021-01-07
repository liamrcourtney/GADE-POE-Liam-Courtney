﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    abstract class Enemy:Character
    {
        Random Object;
        

        public Enemy()
        {
          
            Symbol = "";
            Dmg = 0;
            MaxHp = 0;
        }
        public Enemy(string symbol,int x,int y, int dmg)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Dmg = dmg;
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
