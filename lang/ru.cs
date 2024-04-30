using ATM.DataBase;
using ATM.Function;
using ATM.lang;
using ATM.lang.uz_function.Kommunal;
using ATM.lang.uz_function.Parol;
using ATM.lang.uz_function.Sms;
using ATM.lang.uz_function;
using Mysqlx.Crud;

public static class RuLang
{
    static int limit = 0;
    public static void RussiaSection()
    {
        // NotWorkingLang.ru();
        EnterPassword();
        PasswordCheck();



        int password;
        void EnterPassword()
        {
            if (limit == 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n                        Введите код карты: ");
                password = int.Parse(EnterFunction.ReadPassword());
                Console.WriteLine();
                Console.ResetColor();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\n\n\n                        Введите код карты: ");
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
                    ru_menu();

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
                        Console.WriteLine("       |                 Вы ввели неправильный пароль.                |");
                        Console.WriteLine("       |                    Осталось еще 2 попытки.                   |");
                        Console.WriteLine("       |               Введите «0», чтобы забрать карту.              |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                 Вы ввели неправильный пароль.                |");
                        Console.WriteLine("       |                    Осталось еще 2 попытки.                   |");
                        Console.WriteLine("       |               Введите «0», чтобы забрать карту.              |");
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
                        Console.WriteLine("       |                 Вы ввели неправильный пароль.                |");
                        Console.WriteLine("       |                    Осталось еще 2 попытки.                   |");
                        Console.WriteLine("       |               Введите «0», чтобы забрать карту.              |");
                        Console.WriteLine("       |______________________________________________________________|\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n        ______________________________________________________________");
                        Console.WriteLine("       |                                                              |");
                        Console.WriteLine("       |                 Вы ввели неправильный пароль.                |");
                        Console.WriteLine("       |                    Осталось еще 2 попытки.                   |");
                        Console.WriteLine("       |               Введите «0», чтобы забрать карту.              |");
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
                                Console.WriteLine($"       |            Ваша карта заблокирована: {i} сек.                 |");
                                Console.WriteLine("       |______________________________________________________________|\n\n");

                            }
                            else
                            {
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n        ______________________________________________________________");
                                Console.WriteLine("       |                                                              |");
                                Console.WriteLine($"       |            Ваша карта заблокирована:  {i} сек.                 |");
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
                        Console.WriteLine("       |                   Ваша карта разблокирована.                 |");
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

    public static void ru_menu()
    {
        try
        {

            int menu_uz;
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |                        Главное меню                          |\n");
            Console.Write("       |______________________________________________________________|\n\n");
            Console.Write("        ______________________________________________________________ \n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 1.Проверка баланса                6.Оплата мобильной связи   |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 2.Получите наличные               7.Платежи по кредит        |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 3.СМС-уведомление                 8.Оплата на номер счета    |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 4.Изменить пароль                 9.Переводы                 |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       | 5.коммунальные услуги             0.Выход из программы.      |\n");
            Console.Write("       |                                                              |\n");
            Console.Write("       |______________________________________________________________|\n");

            Console.WriteLine();
            Console.Write("\n\n          Выберите услугу: ");
            menu_uz = int.Parse(EnterFunction.Tanla10());
            Console.ResetColor();
            switch (menu_uz)
            {
                case 0: { NotWorking.ru(); } break;
                case 1: { NotWorking.ru(); } break;
                case 2: { NotWorking.ru(); } break;
                case 3: { NotWorking.ru(); } break;
                case 4: { NotWorking.ru(); } break;
                case 5: { NotWorking.ru(); } break;
                case 6: { NotWorking.ru(); } break;
                case 7: { NotWorking.ru(); } break;
                case 8: { NotWorking.ru(); } break;
                case 9: { NotWorking.ru(); } break;
            }


        }
        catch
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
            Console.WriteLine("       |                                                             |");
            Console.WriteLine("       |                 Используйте только бедра !!!                |");
            Console.WriteLine("       |_____________________________________________________________|");
            Console.ResetColor();
            Thread.Sleep(3000);
            ru_menu();
        }
    }

}
