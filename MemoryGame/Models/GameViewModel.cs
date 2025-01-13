using System.Collections.Generic;

namespace MemoryGame.Models
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        public List<Card> Cards { get; set; }
    }
}