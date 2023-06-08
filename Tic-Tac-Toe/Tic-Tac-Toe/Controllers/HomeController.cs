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

            GameModel.Buttons[buttonpressed - 1] = ButtonModel;

            GameModel.CurrentPlayer += 1;
            return RedirectToAction(nameof(Index));
            //return CheckWin();
        }

        public IActionResult CheckWin()
        {
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