using System;
using System.Collections.Generic;
using System.Text;

namespace POE
{
    class GameEngine
    {
        private Map map;
        private static readonly char H;
        private static readonly char x;
        private static readonly char G;
        private static readonly char o;
        public Character Mooving;


        public Map mappp
        {
            get
            {
                return map;
            }
        }
        public GameEngine()
        {
            new Map(0, 10, 0, 10);


        }
        public bool moveplayer(Character.Movement direction)
        {
            if(Mooving.Moove == Character.Movement.Up)
            {
                return true;
            }
            
            if (Mooving.Moove == Character.Movement.Down)
            {
                return true;
            }
            if (Mooving.Moove == Character.Movement.Left)
            {
                return true;
            }
            if (Mooving.Moove == Character.Movement.Right)
            {
                return true;
            }
            return false;
        }
    }
}
