using ATM.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.lang
{
    public class NotWorkingLang
    {
        public static void uz()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |        Ushbu bo'limda texnik ishlar olib borilmoqda.         |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(3000);
            ProgramMain.Main_atm();
        }
        public static void ru()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |        На данном участке ведутся технические работы.         |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(3000);
            ProgramMain.Main_atm();
        }
        public static void eng()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |     Technical work is being carried out in this section.     |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(3000);
            ProgramMain.Main_atm();
        }
    }
}
