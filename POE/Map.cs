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
        
       
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            Minwidth = minWidth;
            Maxwidth = maxWidth;
            Minheight = minHeight;
            Maxheight = maxHeight;

            width = Rand.Next(Minwidth, Maxwidth);
            height = Rand.Next(Minheight, Maxheight);
            Tile[,] TileMap = new Tile[width, height];

            Create(Tile.TileType.Hero);
            Create(Tile.TileType.Enemy);
            UpdateVision();
        }
        
        public void UpdateVision()
        {
         //   player.CharacterVision[0] = (player.);
        }
        private Tile Create(Tile.TileType type)
        {
            if (type == Tile.TileType.Hero)
            {
               return player = new Hero(Rand.Next(width),Rand.Next(height));
                
            }

            if (type == Tile.TileType.Enemy)
            {
                enemies[E] = new Goblin(Rand.Next(width), Rand.Next(height));
                E++;
                
            }
            return player;
            //if (type == Tile.TileType.Gold)
            //{
            //    return 
            //}
            //if (type == Tile.TileType.Weapon)
            //{
            //    return 
            //}

        }
    }

}
