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
        public int E = 0;
        public int width;
        public int height;
        private Random Rand = new Random();
        public int Minwidth;
        public int Maxwidth;
        public int Minheight;
        public int Maxheight;
        public int Type;
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
         //   player.CharacterVision[0] = (player.);
        }
        private Tile Create(Tile.TileType type)
        {
            if (type == Tile.TileType.Hero)
            {
               return player = new Hero();
                
            }

            if (type == Tile.TileType.Enemy)
            {
                enemies[E] = new Goblin();
                E++;
            }
            return Tile.TileType.Gold;

        }
    }

}
