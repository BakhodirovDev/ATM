using ATM.Function;
using ATM.lang.uz_function;
namespace ATM
{
    public class ProgramMain
    {
        public static void Main_atm()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n        ______________________________________________________________");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       |        Assalomu alaykum Bankomatimziga xush kelibsiz.        |");
                Console.WriteLine("       |______________________________________________________________|\n\n");
                Console.WriteLine("        ______________________________________________________________");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       | 1. O'zbek                                                    |");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       | 2. Русский                                                   |");
                Console.WriteLine("       |                                                              |");
                Console.WriteLine("       | 3. English                             0. Dasturchi haqida   |");
                Console.WriteLine("       |______________________________________________________________|\n\n\n");
                Console.WriteLine();
                Console.Write("        Tilni tanlang / Выберите язык / Select a language: ");
                int lang = int.Parse(EnterFunction.ReadMain());
                Console.ResetColor();

                if (lang == 0)
                {
                    AboutProgrammer.About();
                }
                else if (lang == 1)
                {
                    UzLang.UzbekSection();
                }
                else if (lang == 2)
                {
                    RuLang.RussiaSection();
                }
                else if (lang == 3)
                {
                    EngLang.EnglishSection();
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n\n        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |             Siz noma'lum buyruqni tanladingiz.              |");
                Console.WriteLine("       |_____________________________________________________________|");
                Console.WriteLine("        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |               Вы выбрали неизвестную команду.               |");
                Console.WriteLine("       |_____________________________________________________________|");
                Console.WriteLine("        _____________________________________________________________");
                Console.WriteLine("       |                                                             |");
                Console.WriteLine("       |               You selected an unknown command.              |");
                Console.WriteLine("       |_____________________________________________________________|");
                Thread.Sleep(3000);
                Console.ResetColor();
                Main_atm();
            }
        }
    }
}
