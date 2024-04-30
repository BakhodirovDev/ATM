using ATM.Function;
using ATM.lang.uz_function.Kommunal.Viloyatlar;

namespace ATM.lang.uz_function.Kommunal
{
    public class Elektroenergiya
    {
        public static void main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ______________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |                       Elektroenergiya                        |");
            Console.WriteLine("     |______________________________________________________________|");
            Console.WriteLine("      _____________________________________________________________");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   1. Toshkent                        8. Farg'ona             |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   2. Toshkent viloyati               9. Namangan             |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   3. Buxoro                          10. Andijon             |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   4. Samarqand                       11. Surxondaryo         |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   5. Jizzax                          12. Xorazm              |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   6. Navoiy                          13. Sirdaryo            |");
            Console.WriteLine("     |                                                              |");
            Console.WriteLine("     |   7. Qashqadaryo                     14.Qoraqalpog'iston Res.|");
            Console.WriteLine("     |______________________________________________________________|\n");

            Console.Write("\n       Xizmatni tanlang: ");
            int tanlash = int.Parse(EnterFunction.Tanla14());
            switch(tanlash)
            {
                case 1: ToshkentSh.main(); break;
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
        
    }
}
