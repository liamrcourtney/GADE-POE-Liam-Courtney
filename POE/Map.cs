using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class Map
    {
        private Tile[,] map;
        public Hero player;
        public Enemy[] enemies;
        public int width;
        public int height;
        private Random Rand = new Random();
        public int Minwidth;
        public int Maxwidth;
        public int Minheight;
        public int Maxheight;
        public Map()
        {
            Minwidth = 0;
            Maxwidth = 10;
            Minheight = 0;
            Maxheight = 10;
        }
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            Minwidth = minWidth;
            Maxwidth = maxWidth;
            Minheight = minHeight;
            Maxheight = maxHeight;

            width = Rand.Next(Minwidth, Maxwidth);
            height = Rand.Next(Minheight, Maxheight);
            Tile[,] TileMap = new Tile[width, height];

            //Create()
            //UpdateVision()
        }
        
        public void UpdateVision()
        {

        }
        private Tile Create(Tile.TileType type)
        {
            if (Rand.Next(0, 2) == (int)Tile.TileType.Hero)
            {
                
            }
        }
    }

}
