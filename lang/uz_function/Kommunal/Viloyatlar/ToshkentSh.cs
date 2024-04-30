using ATM.Function;
namespace ATM.lang.uz_function.Kommunal.Viloyatlar
{
    public class ToshkentSh
    {
        public static void main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ______________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |                     Toshkent Shahar                          |");
            Console.WriteLine("     |______________________________________________________________|");
            Console.WriteLine("      _____________________________________________________________");
            Console.WriteLine("     |                                                             |");
           Console.WriteLine($"     |   1.{"",-26} 7.{"",-26}|");
            Console.WriteLine("     |_____________________________________________________________|\n");

            Console.Write("\n       Viloyatni tanlang: ");
            int tanla = int.Parse(EnterFunction.Tanla14());
            switch (tanla)
            {
                case 1: NotWorking.main(); break;
                case 2: NotWorking.main(); break;
                case 3: NotWorking.main(); break;
                case 4: NotWorking.main(); break;
                case 5: NotWorking.main(); break;
                case 6: NotWorking.main(); break;
                case 7: NotWorking.main(); break;
                case 8: NotWorking.main(); break;
                case 9: NotWorking.main(); break;
                case 10: NotWorking.main(); break;
                case 11: NotWorking.main(); break;
                case 12: NotWorking.main(); break;
                case 13: NotWorking.main(); break;
                case 14: NotWorking.main(); break;
                default: xatolik(); break;

            }
        }
        public static void xatolik()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n      ______________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |                            Xatolik                           |");
            Console.WriteLine("     |______________________________________________________________|");
            Thread.Sleep(3000);
            main();
        }

        public static void raqam()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ______________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |                                                     |");
        }
    }
}
