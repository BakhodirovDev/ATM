using ATM.DataBase;
using ATM.lang;
using ATM.lang.uz_function;
using ATM.lang.uz_function.Kommunal;
using ATM.lang.uz_function.Parol;
using ATM.lang.uz_function.Sms;
namespace ATM.Function;

public static class UzLang
{
    static int limit = 0;
    public static void UzbekSection()
    {
        EnterPassword();
        PasswordCheck();



        int password;
        void EnterPassword()
        {
            if (limit == 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n                        Karta kodini kiriting: ");
                password = int.Parse(EnterFunction.ReadPassword());
                Console.WriteLine();
                Console.ResetColor();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\n\n\n                        Karta kodini kiriting: ");
                password = int.Parse(EnterFunction.ReadPassword());
                Console.ResetColor();
                PasswordCheck();

            }
        }

        void PasswordCheck()
        {
            try
            {
                if (password == DataBaseConnection.GetPassWord())
                {
                    uz_menu();

                }
                else if (password == 0)
                {
                    limit = 0;
                    Program.Main();

                }
                else
                {
                    limit++;

                    if (limit == 1)
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                  Xato parol kiritdingiz.                     |");
                        Console.WriteLine("       |           Sizni yana 2 marta urunishingiz qoldi.             |");
                        Console.WriteLine("       |    Kartangizni chiqarib olish uchun '0' raqamini kiriting.   |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                  Xato parol kiritdingiz.                     |");
                        Console.WriteLine("       |           Sizni yana 2 marta urunishingiz qoldi.             |");
                        Console.WriteLine("       |    Kartangizni chiqarib olish uchun '0' raqamini kiriting.   |");
                        Console.WriteLine("       |______________________________________________________________|\n\n\n");
                        Console.ResetColor();

                        EnterPassword();

                    }
                    else if (limit == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\n\n\n\n\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                  Xato parol kiritdingiz.                     |");
                        Console.WriteLine("       |           Sizni yana 1 marta urunishingiz qoldi.             |");
                        Console.WriteLine("       |       Parolni xato kiritsangiz kartangiz blocklanadi.        |");
                        Console.WriteLine("       |    Kartangizni chiqarib olish uchun '0' raqamini kiriting.   |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                  Xato parol kiritdingiz.                     |");
                        Console.WriteLine("       |           Sizni yana 1 marta urunishingiz qoldi.             |");
                        Console.WriteLine("       |       Parolni xato kiritsangiz kartangiz blocklanadi.        |");
                        Console.WriteLine("       |    Kartangizni chiqarib olish uchun '0' raqamini kiriting.   |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Console.WriteLine();
                        Console.ResetColor();
                        EnterPassword();
                    }
                    else if (limit == 3)
                    {
                        for (int i = 30; i >= 0; i--)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (i > 9)
                            {
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                                Console.WriteLine("       |                                                              |");
                                Console.WriteLine($"       |            Sizning kartangiz blocklandi: {i} sek              |");
                                Console.WriteLine("       |______________________________________________________________|\n\n");

                            }
                            else
                            {
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                                Console.WriteLine("       |                                                              |");
                                Console.WriteLine($"       |            Sizning kartangiz blocklandi:  {i} sek              |");
                                Console.WriteLine("       |______________________________________________________________|\n\n");
                            }

                            Console.ResetColor();
                            Thread.Sleep(1000);

                        }
                        Thread.Sleep(1000);
                        limit = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                   Kartangiz blokdan ochildi.                 |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Program.Main();
                    }
                    else
                    {
                        Console.WriteLine($"limit {limit}");
                    }

                }
            }
            catch
            {
                DataBaseError.errorDB();
            }


        }


    }

    public static void uz_menu()
    {
        try
        {

            int menu_uz;
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |                        Bosh menyu                            |\n");
            Console.Write("       |______________________________________________________________|\n\n");
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 1.Balansni tekshirish.            6.Mobil aloqa uchun to'lov |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 2.Naqd pul olish.                 7.Kredit to'lovlari        |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 3.SMS xabarnoma.                  8.Hisob raqamga to'lov     |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 4.Parolni o'zgartirish.           9.O'tkazmalar              |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 5.Kommunal to'lovlar              0.Dasturdan chiqish.       |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |______________________________________________________________|\n");
             
            Console.WriteLine();
            Console.Write("\n\n          Xizmatni tanlang: ");
            menu_uz = int.Parse(EnterFunction.Tanla10());
            Console.ResetColor();
            switch (menu_uz)
            {
                case 0: { DasturdanChiqish.exit_UZ(); } break;
                case 1: { UzBalans.Balans(); } break;
                case 2: { NaqtPulOlish.NaqtPuluz(); }; break;
                case 3: { SmsXabarnoma.Main(); } break;
                case 4: { ChangePassWord.Main(); } break;
                case 5: { MainKommunal.main(); } break;
                case 6: { NotWorking.main(); } break;
                case 7: { NotWorking.main(); } break;
                case 8: { NotWorking.main(); } break;
                case 9: { NotWorking.main(); } break;
            }


        }
        catch
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |                 Faqat sonlardan foydalang !!!               |");
            Console.WriteLine("       |_____________________________________________________________|");
            Console.ResetColor();
            Thread.Sleep(3000);
            uz_menu();
        }
    }
}