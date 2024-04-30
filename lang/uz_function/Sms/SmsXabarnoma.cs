using ATM.Function;

namespace ATM.lang.uz_function.Sms
{
    public class SmsXabarnoma
    {
        public static void Main()
        {
            int sms_uz;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |                    SMS xabarni o'rnatish.                   |");
            Console.WriteLine("       |_____________________________________________________________|");
            Console.WriteLine("\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |   1. SMS Xabarnomani o'rnatish.                             |");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |   2. SMS Xabarnomani o'chirish.                             |");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |   3. Ma'lumot.                                              |");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |   4. Ortga.                                                 |");
            Console.WriteLine("       |_____________________________________________________________|\n\n");

            Console.Write("\n       Xizmatni tanlang: ");
            sms_uz = int.Parse(EnterFunction.Tanla4());
            Console.ResetColor();

            switch (sms_uz)
            {
                case 1: SmsConnect.Connect(); break;
                case 2: SmsDelete.Delete(); break;
                case 3: SmsInfo.Info(); break;
                case 4: UzLang.uz_menu(); break;
            }
        }   

    }              
}
