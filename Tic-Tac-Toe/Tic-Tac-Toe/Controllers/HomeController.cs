using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private void MakeButtons()
        {
            var GameModel = Game.GetInstance();   
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
            GameModel.Buttons.Add(new Button());
        }

        public IActionResult Index()
        {
            var GameModel = Game.GetInstance(); 
            if (!GameModel.Buttons.Any())
            {
                MakeButtons();
            }

            return View(GameModel);
        }


        public IActionResult Button1Pressed()
        {
            int buttonpressed = 1;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button2Pressed()
        {
            int buttonpressed = 2;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button3Pressed()
        {
            int buttonpressed = 3;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button4Pressed()
        {
            int buttonpressed = 4;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button5Pressed()
        {
            int buttonpressed = 5;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button6Pressed()
        {
            int buttonpressed = 6;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult Button7Pressed()
        {
            int buttonpressed = 7;
            return ButtonPressed(buttonpressed);
        }
        public IActionResult Button8Pressed()
        {
            int buttonpressed = 8;
            return ButtonPressed(buttonpressed);
        }
        public IActionResult Button9Pressed()
        {
            int buttonpressed = 9;
            return ButtonPressed(buttonpressed);
        }

        public IActionResult ButtonPressed(int buttonpressed)
        {
            var GameModel = Game.GetInstance();
            int currentplayer = GameModel.CurrentPlayer;
            string val = "X";
            if (currentplayer % 2 == 0)
            {
                val = "X";
            }
            else if (currentplayer % 2 == 1)
            {
                val ="O";
            }
            var ButtonModel = new Button();
            ButtonModel.ButtonValue = val;
            if (GameModel.Buttons[buttonpressed-1].ButtonValue == " ")
            {
                GameModel.Buttons[buttonpressed - 1] = ButtonModel;
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

            GameModel.CurrentPlayer += 1;
            return CheckWin();
        }

        public IActionResult CheckWin()
        {
            var GameModel = Game.GetInstance();
            string won = "false";
            bool draw = false;
            //check wins
            //check X
            //horizontaal
            if (GameModel.Buttons[0].ButtonValue == "X" && GameModel.Buttons[1].ButtonValue == "X" && GameModel.Buttons[2].ButtonValue == "X")
            {
                won = "X";
            }
            if (GameModel.Buttons[3].ButtonValue == "X" && GameModel.Buttons[4].ButtonValue == "X" && GameModel.Buttons[5].ButtonValue == "X")
            {
                won = "X";
            }
            if (GameModel.Buttons[6].ButtonValue == "X" && GameModel.Buttons[7].ButtonValue == "X" && GameModel.Buttons[8].ButtonValue == "X")
            {
                won = "X";
            }
            //verticaal
            if (GameModel.Buttons[0].ButtonValue == "X" && GameModel.Buttons[3].ButtonValue == "X" && GameModel.Buttons[6].ButtonValue == "X")
            {
                won = "X";
            }
            if (GameModel.Buttons[1].ButtonValue == "X" && GameModel.Buttons[4].ButtonValue == "X" && GameModel.Buttons[7].ButtonValue == "X")
            {
                won = "X";
            }
            if (GameModel.Buttons[2].ButtonValue == "X" && GameModel.Buttons[5].ButtonValue == "X" && GameModel.Buttons[8].ButtonValue == "X")
            {
                won = "X";
            }
            //schuin
            if (GameModel.Buttons[0].ButtonValue == "X" && GameModel.Buttons[4].ButtonValue == "X" && GameModel.Buttons[8].ButtonValue == "X")
            {
                won = "X";
            }
            if (GameModel.Buttons[2].ButtonValue == "X" && GameModel.Buttons[4].ButtonValue == "X" && GameModel.Buttons[6].ButtonValue == "X")
            {
                won = "X";
            }

            //check O
            //horizontaal
            if (GameModel.Buttons[0].ButtonValue == "O" && GameModel.Buttons[1].ButtonValue == "O" && GameModel.Buttons[2].ButtonValue == "O")
            {
                won = "O";
            }
            if (GameModel.Buttons[3].ButtonValue == "O" && GameModel.Buttons[4].ButtonValue == "O" && GameModel.Buttons[5].ButtonValue == "O")
            {
                won = "O";
            }
            if (GameModel.Buttons[6].ButtonValue == "O" && GameModel.Buttons[7].ButtonValue == "O" && GameModel.Buttons[8].ButtonValue == "O")
            {
                won = "O";
            }
            //verticaal
            if (GameModel.Buttons[0].ButtonValue == "O" && GameModel.Buttons[3].ButtonValue == "O" && GameModel.Buttons[6].ButtonValue == "O")
            {
                won = "O";
            }
            if (GameModel.Buttons[1].ButtonValue == "O" && GameModel.Buttons[4].ButtonValue == "O" && GameModel.Buttons[7].ButtonValue == "O")
            {
                won = "O";
            }
            if (GameModel.Buttons[2].ButtonValue == "O" && GameModel.Buttons[5].ButtonValue == "O" && GameModel.Buttons[8].ButtonValue == "O")
            {
                won = "O";
            }
            //schuin
            if (GameModel.Buttons[0].ButtonValue == "O" && GameModel.Buttons[4].ButtonValue == "O" && GameModel.Buttons[8].ButtonValue == "O")
            {
                won = "O";
            }
            if (GameModel.Buttons[2].ButtonValue == "O" && GameModel.Buttons[4].ButtonValue == "O" && GameModel.Buttons[6].ButtonValue == "O")
            {
                won = "O";
            }

            if (won == "false" && GameModel.CurrentPlayer == 9)
            {
                draw = true;
            }

            if (won == "X")
            {
                GameModel.ScorePlayerX += 1;
                return ResetBoard();
            }
            else if (won == "O")
            {
                GameModel.ScorePlayerO += 1;
                return ResetBoard();
            }
            else if (draw == true)
            {
                return ResetBoard();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ResetBoard()
        {
            var GameModel = Game.GetInstance();
            GameModel.CurrentPlayer = 0;
            for (int i = 0; i <= 8; i++)
            {
                GameModel.Buttons[i] = new Button();
            }
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}