using System;
using System.Collections.Generic;

namespace MemoryGame.Models
{
    
    public class GameDetails
    {
        public int GameID { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public string GameStatus { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

    }
}