using System.Collections.Generic;
using System.Linq;

namespace Challenge3OO
{
    public class ClGame : Game
    {

        public string Name { get; set; }
        public List<int> Results { get; set; } = new List<int>();

        public ClGame(string name, List<int> results)
        {
            this.Name = name;
            Results = results;
        }

        public double GetAverage()
        {
            if (Results.Count == 0) return 0;
            return (double)GetTotal() / (double)Results.Count();
    }

        public int GetTotal()
    {
        int total = 0;
        foreach (var element in Results)
        {
            total += element;
        }
        return total;
    }

    public override int RollAllDice()
    {
        foreach (var dice in Dice)
        {
            var result = dice.Roll();
            Results.Add(result);
        }

        return 1;
    }
}
}
