using ATM.DataBase;
using ATM.Function;
namespace ATM.lang.uz_function.Sms
{
    public class SmsConnect
    {
        public static void Connect() 
        {
            {
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                int a = 1;

                Console.WriteLine("\n        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |                  SMS Xabarnomani o'rnatish.                 |");
                Console.WriteLine("       |_____________________________________________________________|\n");

                if (DataBaseConnection.GetNumber() != 0)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine($"       |               SMS xabarnoma holati: O'rnatilgan             |");
                    Console.WriteLine("       |_____________________________________________________________|\n");
                    Console.WriteLine("        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |              Ulangan Raqamni o'zgartirasizmi?                |");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |      1-HA                                         2-YO'Q     |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Console.Write("\n       Xizmatni tanlang: ");
                    a = int.Parse(EnterFunction.Tanla2());
                    Console.ResetColor();

                }
                
                
               

                if (a == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n          Raqamni kiriting: +998 ");
                    DataBaseConnection.NewNumberUpload(EnterFunction.EnterNumber());
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |           SMS Xabarnoma muvaffaqiyatli o'rnatildi.          |");
                    Console.WriteLine("       |_____________________________________________________________|\n");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\n\n\n\n\n\n        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |                 Boshqa amaliyot bajarasizmi?                 |");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |      1-HA                                         2-YO'Q     |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Console.Write("\n       Xizmatni tanlang: ");
                    a = int.Parse(EnterFunction.Tanla2());
                    if (a == 1) UzLang.uz_menu();
                    else if (a == 2) DasturdanChiqish.exit_UZ();
                }
                else if (a == 2) UzLang.uz_menu();
            }
        }
    }
}
