using System;
using System.Collections.Generic;
using System.IO;

namespace Challenge3OO

{
    public class Die
    {

        public int Sides { get; set; }

        public Die()
        {
            Sides = 6;
        }

        public Die(int num)
        {
            Sides = num;
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides + 1);
        }
    }
}

