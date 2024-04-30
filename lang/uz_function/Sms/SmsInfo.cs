using ATM.DataBase;
using ATM.Function;
namespace ATM.lang.uz_function.Sms
{
    public class SmsInfo
    {
        public static void Info()
        {
            {
                Console.Clear();
                int number = DataBaseConnection.GetNumber();
                string result;
                if(number == 0)
                {
                    result = "O'rnatilmagan";
                }
                else
                {
                    int r1, r2, r3, r4, r5, r6, r7, r8;
                    r1 = number / 10000000;
                    r2 = number / 1000000 % 10;
                    r3 = number / 100000 % 10;
                    r4 = number / 10000 % 10;
                    r5 = number / 1000 % 10;
                    r6 = number / 100 % 10;
                    r7 = number / 10 % 10;
                    r8 = number / 1 % 10;
                    result = $"+998 ({r1}) {r2}{r3}{r4} {r5}{r6} {r7}{r8}";
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n\n\n        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |               SMS Xabarnoma haqida ma'lumot.                |");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine($"       |       SMS xabanoma ulangan raqam: {result,-26}|");
                Console.WriteLine("       |_____________________________________________________________|\n\n");
                Console.WriteLine("        ______________________________________________________________");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       |                Boshqa amaliyot bajarasizmi?                  |");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       |      1-HA                                         2-YO'Q     |");
                Console.WriteLine("       |______________________________________________________________|\n\n");
                int a;
                Console.Write("\n        Xizmatni tanlang: ");
                a = int.Parse(EnterFunction.Tanla2());
                if (a == 1) UzLang.uz_menu();
                else if(a == 2) DasturdanChiqish.exit_UZ();

            }
        }
    }
}
