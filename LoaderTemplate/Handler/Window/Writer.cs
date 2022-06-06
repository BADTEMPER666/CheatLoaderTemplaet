using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoaderTemplate.Handler;

namespace LoaderTemplate.Handler.Window
{
    internal class Writer
    {
        public static int options = 0;

        public static void writeLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WindowUtility.centerText(" ___       ________  ________  ________  _______   ________     ");
            WindowUtility.centerText(@"|\  \     |\   __  \|\   __  \|\   ___ \|\  ___ \ |\   __  \    ");
            WindowUtility.centerText(@"\ \  \    \ \  \|\  \ \  \|\  \ \  \_|\ \ \   __/|\ \  \|\  \   ");
            WindowUtility.centerText(@" \ \  \    \ \  \\\  \ \   __  \ \  \ \\ \ \  \_|/_\ \   _  _\  ");
            WindowUtility.centerText(@"  \ \  \____\ \  \\\  \ \  \ \  \ \  \_\\ \ \  \_|\ \ \  \\  \| ");
            WindowUtility.centerText(@"   \ \_______\ \_______\ \__\ \__\ \_______\ \_______\ \__\\ _\ ");
            WindowUtility.centerText(@"    \|_______|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void optionsWriter(string text)
        {
            options++;
            Console.WriteLine($"{options}.) {text}");
        }

        public static void resetOptions()
        {
            options = 0;
        }
    }
}
