using ATM.Function;

namespace ATM.lang.uz_function.Kommunal
{
    public class MainKommunal
    {
        public static void main()
        {
            Console.Clear();
            int tanla;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n      ______________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |                      Kommunal to'lovlar                      |");
            Console.WriteLine("     |______________________________________________________________|");
            Console.WriteLine("\n      _____________________________________________________________");
            Console.WriteLine("     |                                                             |");
            Console.WriteLine("     |   1. Elektroenergiya                                        |");
            Console.WriteLine("     |                                                             |");
            Console.WriteLine("     |   2. Suv Ta'minoti                                          |");
            Console.WriteLine("     |                                                             |");
            Console.WriteLine("     |   3. Gaz                                                    |");
            Console.WriteLine("     |                                                             |");
            Console.WriteLine("     |   4. Ortga.                                                 |");
            Console.WriteLine("     |_____________________________________________________________|\n\n");
            Console.Write("\n       Xizmatni tanlang: ");
            tanla = int.Parse(EnterFunction.Tanla4());
            switch(tanla)
            {
                case 1: Elektroenergiya.main(); break;
                case 2: NotWorking.main(); break;
                case 3: NotWorking.main(); break;
                case 4: UzLang.uz_menu(); break;
            }


        }
    }
}
