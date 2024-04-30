using ATM.DataBase;
using ATM.Function;
using System.Data.Common;

namespace ATM.lang.uz_function.Parol
{
    public class ChangePassWord
    {
        public static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            int joriy_pass;
            Console.WriteLine("\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |                    Parolni o'zgartirish.                    |");
            Console.WriteLine("       |_____________________________________________________________|\n\n\n\n\n");
            Console.Write("\n\n       Joriy parolni kiriting(Bekor qilish - 0): ");
            joriy_pass = int.Parse(EnterFunction.ReadPassword());
            if (joriy_pass == DataBaseConnection.GetPassWord())
            {
                Console.Clear();
                int old_pass, new_pass;
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n               Yangi parolni kiriting: ");
                old_pass = int.Parse(EnterFunction.ReadPassword());
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n               Parolni tasdiqlang: ");
                new_pass = int.Parse(EnterFunction.ReadPassword());
                Console.Clear();
                if (old_pass == new_pass)
                {
                    int a;
                    Console.Clear();
                    DataBaseConnection.NewPasswordUpload(new_pass);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |             Parolni muvaffaqiyatli o'zgartirildi            |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Thread.Sleep(2000);
                    Console.Clear();
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
                else
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |            Xatolik! Siz kiritgan parollar mos emas.         |");
                    Console.WriteLine("       |_____________________________________________________________|\n\n\n\n\n");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    Main();

                }
            }
            else if (joriy_pass == 0)
            {
                Thread.Sleep(1000);
                UzLang.uz_menu();
            }
            else
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |               Joriy parolni xato kiritdingiz.               |");
                Console.WriteLine("       |_____________________________________________________________|\n\n\n\n\n");
                Console.ResetColor();
                Thread.Sleep(3000);
                Main();
            }
        }
    }
}
