namespace MemoryGame.Models{
    public class CardDetails
    {
        public int CardID { get; set; }
        public int GameID { get; set; }
        public string? CardPosition { get; set; }
        public string? CardValue { get; set; }
        public bool IsMatched { get; set; }
	

    }
}