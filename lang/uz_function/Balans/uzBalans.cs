using ATM.DataBase;
using ATM.Function;

public static class UzBalans
{
    public static void Balans()
    { 
        try
        {             
            double balans = DataBaseConnection.GetBalance();
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            EnterFunction.PrintCash("              Balansingiz", 0, balans, 25);
            Console.WriteLine("       |______________________________________________________________|\n\n");

            Console.WriteLine("\n\n        ______________________________________________________________");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |                 Boshqa amaliyot bajarasizmi?                 |");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |       1-HA                                        2-YO'Q     |");
            Console.WriteLine("       |______________________________________________________________|\n\n");


            Console.WriteLine();
            Console.Write("\n         Xizmatni tanlang: ");
            int back1 = int.Parse(EnterFunction.Tanla2());
            Console.ResetColor();

            if (back1 == 1) UzLang.uz_menu();
            else UzLang.uz_menu();

        }
        catch
        {
            DataBaseError.errorDB();
        }
    }
}
