namespace Tic_Tac_Toe.Models
{
    public class Score
    {
        public int Player { get; set; }
        public int ScorePlayerX { get; set; }
        public int ScorePlayerO { get; set; }
        public string PlayerLetter { get; set; }
        
    }
    public class Button
    {
        public int ButtonId { get; set; }
        public string ButtonValue { get; set; }
        public List<Button> Buttons { get; set; }
    }
}