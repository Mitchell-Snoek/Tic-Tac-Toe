namespace Tic_Tac_Toe.Models
{
    public class IndexModel
    {
        public int Player { get; set; }
        public int ScorePlayerX { get; set; }
        public int ScorePlayerO { get; set; }
        public string PlayerLetter { get; set; }
        public IndexModel Button { get; set; }
        public List<IndexModel> Buttons { get; set; }
    }
}