namespace ATM.lang.uz_function
{
    public class AboutProgrammer
    {
        public static void About()
        {
            int holat = 0;

            for (int i = 0; i <= 6; i++)
            {
                if (holat == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |                     Dasturchi Haqida.                       |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Thread.Sleep(1000);
                    holat++;
                }
                else if (holat == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Thread.Sleep(1000);
                    holat--;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\n\n\n\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |         Ushbu dastur PDP Academy G6 guruh Talabasi:         |");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |               Bahodirov  Behruz  Botirovich                 |");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |        Tomonidan tuzildi. E'tiboringiz uchun raxmat.        |");
            Console.WriteLine("       |_____________________________________________________________|");

            Thread.Sleep(10000);
            ProgramMain.Main_atm();
            return;
        }
    }
}
