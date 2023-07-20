using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace KeyBoard
{
    public class Game
    {
        public void start()
        {
            RunFirstmenu();
        }
        private void RunFirstmenu()
        {
            string prompt = @"
              _                            _          _   _                                       
             | |                          | |        | | | |                                      
__      _____| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___    __ _  __ _ _ __ ___   ___ 
\ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \  / _` |/ _` | '_ ` _ \ / _ \
 \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/ | (_| | (_| | | | | | |  __/
  \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___|  \__, |\__,_|_| |_| |_|\___|
                                                                        __/ |                     
                                                                       |___/                      
make a choice between the available";
            string[] options = { "play", "about", "Exit" };
            Menu menu = new Menu(options, prompt);
            int selectedindex = menu.Run();

            switch (selectedindex)
            {
                case 0:
                    Play();
                    break;
                case 1:
                    About(); break;
                case 2:
                    ExitGame(); break;
            }

        }
        public void ExitGame()
        {
            WriteLine("\nPress any key to Exit....");
            ReadKey(true);
            Environment.Exit(0);
        }
        public void About()
        {
            Clear();
            WriteLine("this game is made by me");
            WriteLine("the uses assets from http://www.patorjk.com/software/taag");
            WriteLine("this is just a demo ....");
            WriteLine("\nPress any key to Exit....");
            ReadKey(true);
            RunFirstmenu();
        }
        public void Play()
        {
            string propmt = "chooose a color that you wanna see";
            string[] options = { "red", "yellow", "blue", "green" };
            Menu ColorMenu = new Menu(options, propmt);
            int selectedindex = ColorMenu.Run();
            BackgroundColor = ConsoleColor.Black;

            switch (selectedindex)
            {

                case 0:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("here you are !! some red text");
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("here you are !! some Yellow text");
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("here you are !! some blue text");
                    break;
                case 3:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("here you are !! some green text");
                    break;

            }
            ResetColor();
            WriteLine("this is all for the demo... , press enter to continue");
            ConsoleKey keyPressed = ReadKey(true).Key;
            if (keyPressed == ConsoleKey.Enter)
            {
                RunFirstmenu();
            }

        }
    }
}
