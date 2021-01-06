﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class Tile
    {
        public int Y;
        public int X;
        public string TileType1;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold, 
            Weapon
               
        }
        TileType Type1;
        
        public Tile()
        {
            TileType1 = Type1.ToString();
            X=0;
            Y=0;

        }    
        public Tile(int x, int y)
        {
            
                       
            X = x;
            Y = y;

        }
    }

    class Obstacle : Tile
    {

        public Obstacle()
        {
            new Tile(X, Y);
        }
    }
    class EmptyTile: Tile
    {
        public EmptyTile()
        {
            new Tile(X, Y);
        }
    }

}