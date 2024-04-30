using ATM.DataBase;
using ATM.Function;
using ATM.lang;
using System.Linq.Expressions;
public static class NaqtPulOlish
{
    public static void NaqtPuluz()
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("        ______________________________________________________________");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |                       Naqd pul olish                         |");
        Console.WriteLine("       |______________________________________________________________|\n\n");
        Console.WriteLine("        ______________________________________________________________ ");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |    1.50000 so'm                          5.500000 so'm       |");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |    2.100000 so'm                         6.1000000 so'm      |");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |    3.150000 so'm                         7.Boshqa summa      |");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |    4.300000 so'm                         8.Orqaga            |");
        Console.WriteLine("       |______________________________________________________________|");

        Console.WriteLine();
        int tanlash;
        Console.Write("\n\n\n         Xizmatni tanlang: ");
        tanlash = int.Parse(EnterFunction.Tanla8());
        Console.ResetColor();

        switch (tanlash)
        {
            case 1: { Naqtpul(50000); } break;
            case 2: { Naqtpul(100000); } break;
            case 3: { Naqtpul(150000); } break;
            case 4: { Naqtpul(300000); } break;
            case 5: { Naqtpul(500000); } break;
            case 6: { Naqtpul(1000000); } break;
            case 7: { Other_Cash(); } break;
            case 8: { UzLang.uz_menu(); } break;
            default: { } break;
        }
    }

    public static void Other_Cash()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("        ______________________________________________________________");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |                       Naqd pul olish                         |");
        Console.WriteLine("       |______________________________________________________________|\n\n\n\n\n\n\n\n\n\n");
        Console.Write("             Summani kiriting: ");
        double summa = float.Parse(EnterFunction.OtherCash());
        Naqtpul(summa);
    }
    public static void Naqtpul(double summa)
    {
        double pul = summa * 0.01;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("        ______________________________________________________________");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |                    Naqt pul yechib olish                     |");
        Console.WriteLine("       |______________________________________________________________|");
        Console.WriteLine("        ______________________________________________________________");
        Console.WriteLine("       |                                                              |");
        EnterFunction.PrintCash("Chiqariladigan summa",22,summa,31);
        Console.WriteLine("       |                                                              |");
        EnterFunction.PrintCash("Komissiya (1%)", 22, pul, 31);
        Console.WriteLine("       |                                                              |");
        EnterFunction.PrintCash("Jami summa",22,summa + pul,31);
        Console.WriteLine("       |______________________________________________________________|\n");
        Console.WriteLine("        ______________________________________________________________");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |                     Amaliyotni Tasdiqlang.                   |");
        Console.WriteLine("       |                                                              |");
        Console.WriteLine("       |      1 - Tasdiqlash                         2 - Ortga        |");
        Console.WriteLine("       |______________________________________________________________|\n");
        Console.Write("\n         Xizmatni tanlang: ");
        int check = int.Parse(EnterFunction.Tanla2());
        Thread.Sleep(3000);


        if (check == 1)
        {
            try
            {
                if (DataBaseConnection.GetBalance() >= summa + pul)
                {
                    DataBaseConnection.CashOut(summa + pul);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |                    Amalyot  bajarilmoqda...                  |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Thread.Sleep(3000);
                    ///sound

                    Console.Clear();

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |                      Pulingizni oling.                       |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ///sound


                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\n\n\n\n        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |                 Boshqa amaliyot bajarasizmi?                 |");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |       1-HA                                        2-YO'Q     |");
                    Console.WriteLine("       |______________________________________________________________|\n\n\n\n");
                    Console.Write("\n         Xizmatni tanlang: ");
                    int amal_void = int.Parse(EnterFunction.Tanla2());
                    Console.ResetColor();
                    if (amal_void == 1)
                    {
                        UzLang.uz_menu();
                    }
                    else if (amal_void == 2) DasturdanChiqish.exit_UZ();

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                    Console.WriteLine("       |                                                              |");
                    Console.WriteLine("       |              Hisobingizda mablag' yetarli emas.              |");
                    Console.WriteLine("       |______________________________________________________________|\n\n");
                    Thread.Sleep(3000);
                    NaqtPuluz();
                }
            }
            catch
            {
                DataBaseError.errorDB();
            }
        }
        else if (check == 2)
        {
            NaqtPuluz();
        }
        else
        {

        }
  
    }






}

