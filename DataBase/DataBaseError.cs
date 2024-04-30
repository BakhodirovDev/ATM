    using ATM.Function;
    namespace ATM.DataBase
    {
        public static class DataBaseError
        {
            public static void errorDB()
            {

                try
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |          Ma'lumotlar bazasi bilan aloqa yo'q :(             |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |           Baza bilan qayta ulanishni xahlaysizmi ?          |");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |          1 - HA                             2 - Yo'q        |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Console.Write("\n\n         Xizmatni tanlang: ");

                    int tanla = int.Parse(EnterFunction.Tanla2());
                    Console.ResetColor();
                    if (tanla == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                        Console.WriteLine("       |                                                             |");
                        Console.WriteLine("       |  Kutishingizni so'raymiz baza bilan aloqa o'rnatilmoqda...  |");
                        Console.WriteLine("       |_____________________________________________________________|");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        Program.Main();
                    }
                    else if (tanla == 2)
                    {
                        return;
                    }
                    Console.ResetColor();
                    Console.ReadKey();

                    Program.Main();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n        _____________________________________________________________");
                    Console.WriteLine("       |                                                             |");
                    Console.WriteLine("       |             Faqat 1 yoki 2 raqamidan foydalang.             |");
                    Console.WriteLine("       |_____________________________________________________________|");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    errorDB();
                }

            }
        }
    }
