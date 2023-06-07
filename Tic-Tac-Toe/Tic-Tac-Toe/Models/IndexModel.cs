namespace Tic_Tac_Toe.Models
{
    public class Game
    {
        public int CurrentPlayer { get; set; }
        public int ScorePlayerX { get; set; }
        public int ScorePlayerO { get; set; }
        public List<Button> Buttons { get; set; }

    }
    public class Button
    {
        public string ButtonValue { get; set; }
    }
}