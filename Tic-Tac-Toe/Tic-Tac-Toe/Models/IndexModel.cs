namespace Tic_Tac_Toe.Models
{
    public class Game
    {
        private static Game _game = null;
        public static Game GetInstance(bool isNew = false)
        {
            if (_game == null || isNew)
            {
                _game = new Game();
            }

            return _game;
        }

        public int CurrentPlayer { get; set; }
        public string Hidden { get; set; }
        public string PlayerWon { get; set; }
        public int ScorePlayerX { get; set; }
        public int ScorePlayerO { get; set; }
        public List<Button> Buttons { get; set; }

        public Game()
        {
            Buttons = new List<Button>();
            Hidden = "Hidden";
            PlayerWon = "";
        }
    }
    public class Button
    {
        public string ButtonValue { get; set; }

        public Button()
        {
            ButtonValue = " ";
        }
    }
}