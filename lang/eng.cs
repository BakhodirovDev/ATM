using ATM.DataBase;
using ATM.Function;
using ATM.lang;
using ATM.lang.uz_function.Kommunal;
using ATM.lang.uz_function.Parol;
using ATM.lang.uz_function.Sms;
using ATM.lang.uz_function;

public static class EngLang
{
    static int limit = 0;
    public static void EnglishSection()
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
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n                        Enter the card code: ");
                password = int.Parse(EnterFunction.ReadPassword());
                Console.WriteLine();
                Console.ResetColor();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\n\n\n                        Enter the card code: ");
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
                    eng_menu();

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
                        Console.WriteLine("       |               You entered the error password.                |");
                        Console.WriteLine("       |                You have 2 more attempts left.                |");
                        Console.WriteLine("       |           Enter the number '0' to extract your card.         |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |               You entered the error password.                |");
                        Console.WriteLine("       |                You have 2 more attempts left.                |");
                        Console.WriteLine("       |           Enter the number '0' to extract your card.         |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Console.ResetColor();

                        EnterPassword();

                    }
                    else if (limit == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\n\n\n\n\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |               You entered the error password.                |");
                        Console.WriteLine("       |                You have 1 more attempts left.                |");
                        Console.WriteLine("       |   If you enter a password error, your card will be blocked.  |");
                        Console.WriteLine("       |           Enter the number '0' to extract your card.         |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |               You entered the error password.                |");
                        Console.WriteLine("       |                You have 1 more attempts left.                |");
                        Console.WriteLine("       |   If you enter a password error, your card will be blocked.  |");
                        Console.WriteLine("       |           Enter the number '0' to extract your card.         |");
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
                                Console.WriteLine($"       |                  Your card blocked: {i} sek                   |");
                                Console.WriteLine("       |______________________________________________________________|\n\n");

                            }
                            else
                            {
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                                Console.WriteLine("       |                                                              |");
                                Console.WriteLine($"       |                  Your card blocked:  {i} sek                   |");
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
                        Console.WriteLine("       |               Your card opened from the block.               |");
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

    public static void eng_menu()
    {
        try
        {

            int menu_uz;
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |                             Menu                             |\n");
            Console.Write("       |______________________________________________________________|\n\n");
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 1.Checking the balance            6.Mobile payment           |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 2.Cash withdrawal                 7.Credit fees              |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 3.SMS notification                8.Account number           |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 4.Change Password                 9.Transfers                |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 5.Utility bills                   0.Exit the program.        |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |______________________________________________________________|\n");

            Console.WriteLine();
            Console.Write("\n\n          Choose a service: ");
            menu_uz = int.Parse(EnterFunction.Tanla10());
            Console.ResetColor();
            switch (menu_uz)
            {
                case 0: { NotWorking.eng(); } break;
                case 1: { NotWorking.eng(); } break;
                case 2: { NotWorking.eng(); } break;
                case 3: { NotWorking.eng(); } break;
                case 4: { NotWorking.eng(); } break;
                case 5: { NotWorking.eng(); } break;
                case 6: { NotWorking.eng(); } break;
                case 7: { NotWorking.eng(); } break;
                case 8: { NotWorking.eng(); } break;
                case 9: { NotWorking.eng(); } break;
            }


        }
        catch
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |                    Just use the numbers !!!                 |");
            Console.WriteLine("       |_____________________________________________________________|");
            Console.ResetColor();
            Thread.Sleep(3000);
            eng_menu();
        }
    }

}
