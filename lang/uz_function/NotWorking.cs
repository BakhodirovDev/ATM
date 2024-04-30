using ATM.Function;

namespace ATM.lang.uz_function
{
    public class NotWorking
    {
        public static void main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |        Ushbu bo'limda texnik ishlar olib borilmoqda.         |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(4000);
            UzLang.uz_menu();
        }

        public static void ru()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |          В этом отделе ведутся технические работы.           |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(4000);
            RuLang.ru_menu();
        }

        public static void eng()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |     Technical work is being carried out in this section.     |");
            Console.WriteLine("       |______________________________________________________________|\n\n");
            Thread.Sleep(4000);
            EngLang.eng_menu();
        }
    }
}
