using System.Collections.Generic;

namespace Challenge3OO
{
    public abstract class Game
    {

        public List<Die> Dice { get; set; } = new List<Die>();


        public abstract int RollAllDice();

        public void AddDie()
        {
            Dice.Add(new Die());
        }

        public void AddDie(int sides)
        {
            Dice.Add(new Die(sides));
        }

    }
}