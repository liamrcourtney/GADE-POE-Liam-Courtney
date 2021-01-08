using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    public abstract class Tile
    {
        protected int Y;
        protected int X;
        public string TileType1;
      

        public enum TileType
        {
            Hero,
            Enemy,
            Gold, 
            Weapon
               
        }
        public TileType Type1;

        public TileType Type
        {
            get
            {
                return Type1;
            }
            set
            {
                Type1 = value;
            }
        }
        
        public Tile()
        {
            TileType1 = Type1.ToString();
            X=0;
            Y=0;

        }    
        public Tile( int x, int y)
        {

                       
            X = x;
            Y = y;

        }
    }

    class Obstacle : Tile
    {

        public Obstacle() : base()
        {
            X = 0;
            Y = 0;
        }
    }
    class EmptyTile: Tile
    {
        public EmptyTile() : base()
        {
            X = 0;
            Y = 0;
        }
    }

}
