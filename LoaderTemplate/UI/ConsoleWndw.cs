using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoaderTemplate.Handler;
using LoaderTemplate.Handler.Window;

namespace LoaderTemplate.UI
{
    internal class ConsoleWndw
    {
        static void Main(string[] args)
        {
            Startup();
        }

        static void Startup()
        {
            //set size and title, also removes the scroll bar unless you resize it
            Console.BufferWidth = Console.WindowWidth = 110;
            Console.BufferHeight = Console.WindowHeight = 28;
            Console.Title = "Loader Template";


            WindowUtility.MoveWindowToCenter();
            Options();
            Console.ReadLine();
        }

        static void Options()
        {
            Console.Clear();
            Writer.writeLogo();
            Console.WriteLine("");

            Writer.optionsWriter("Inject");
            Writer.optionsWriter("Exit");

            var input = Console.ReadLine();

            if (input == "1")
            {
                //inject your cheat here
            }

            else if (input == "2")
            {
                Environment.Exit(0);
            }

            if (input != "1" || input != "2")
            {
                Writer.resetOptions(); //reset the int varaible
                Options();
            }
        }
    }
}
