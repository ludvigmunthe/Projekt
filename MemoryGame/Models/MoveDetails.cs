
namespace MemoryGame.Models{
public class MoveDetails
    {
        public int MoveID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int FirstCardID { get; set; }
        public int SecondCardID { get; set; }
        public bool IsMatch { get; set; }
        public DateTime MoveTime { get; set; }

    }
}