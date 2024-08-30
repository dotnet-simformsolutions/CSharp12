using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Features.Demo
{
    // Alias the Dictionary<string, List<int>> type
    using PlayerScores = System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>>;

    class Game
    {
        public PlayerScores Scores { get; } = new PlayerScores();

        public void AddScore(string player, int score)
        {
            if (!Scores.ContainsKey(player))
            {
                Scores[player] = new List<int>();
            }
            Scores[player].Add(score);
        }

        public void DisplayScores()
        {
            foreach (var entry in Scores)
            {
                Console.WriteLine($"{entry.Key}: {string.Join(", ", entry.Value)}");
            }
        }
    }
}
