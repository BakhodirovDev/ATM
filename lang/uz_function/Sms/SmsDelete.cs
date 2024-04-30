using ATM.DataBase;
using ATM.Function;
namespace ATM.lang.uz_function.Sms
{
    public class SmsDelete
    {
        public static void Delete()
        {
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |                  SMS Xabarnomani o'chirish.                 |");
                Console.WriteLine("       |_____________________________________________________________|\n\n");
                int a;
                if (DataBaseConnection.GetNumber() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine($"       |               SMS xabarnoma holati: O'rnatilgan             |");
                    Console.WriteLine("       |_____________________________________________________________|\n");
                    Console.WriteLine("         ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |                 Boshqa amaliyot bajarasizmi?                 |");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |      1-HA                                         2-YO'Q     |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Console.Write("\n       Xizmatni tanlang: ");
                    a = int.Parse(EnterFunction.Tanla2());
                    Console.ResetColor();

                }

                Console.WriteLine("        ______________________________________________________________");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       |              Xaqiqatdan ham o'chirmoqchimisiz?               |");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       |      1-HA                                         2-YO'Q     |");
                Console.WriteLine("       |______________________________________________________________|\n\n");
                
                Console.Write("\n       Xizmatni tanlang: ");
                a = int.Parse(EnterFunction.Tanla2());
                if (a == 1)
                {
                    Console.Clear();
                    DataBaseConnection.NewNumberUpload(0);
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |           SMS Xabarnomani muvaffaqiyatli o'chirildi.        |");
                    Console.WriteLine("       |_____________________________________________________________|\n\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n         ______________________________________________________________");
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
