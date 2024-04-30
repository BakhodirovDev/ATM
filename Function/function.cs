namespace ATM.Function
{
    public static class EnterFunction
    {
        // Parolni consolga chiqarmasdan o'qib olish uchun funksiya
        public static string ReadPassword()
        {
            string parol = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (parol.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        parol = parol.Substring(0, parol.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if (char.IsDigit(key.KeyChar) && parol.Length < 4)
                {
                    // Raqam kiritishni cheklash, faqat 4 ta belgi
                    // Parolni yozish, "*" shaklida ko'rsatish
                    Console.Write("*");
                    parol += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || parol.Length == 0);

            // Yangi qator chiqish
            Console.WriteLine();

            return parol;
        }



        // Bosh menyudagi tilni tanlash 
        public static string ReadMain()
        {
            string til = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (til.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        til = til.Substring(0, til.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3' || key.KeyChar == '0') && til.Length < 1)
                {
                    // Raqam kiritishni cheklash, faqat bir belgi
                    // Parolni yozish, "*" shaklida ko'rsatish
                    Console.Write(key.KeyChar);
                    til += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || til.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            // Yangi qator chiqish
            Console.WriteLine();

            // Raqamni tekshirish
            if (til == "1" || til == "2" || til == "3" || til == "0")
            {
                return til;
            }
            else
            {
                return ReadMain();
            }
        }

        // 2ta tanlash uchun
        public static string Tanla2()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar == '1' || key.KeyChar == '2') && tanla.Length < 1)
                {
                    // Raqam kiritishni cheklash, faqat bir belgi
                    // Parolni yozish, "*" shaklida ko'rsatish
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            // Yangi qator chiqish
            Console.WriteLine();

            // Raqamni tekshirish
            if (tanla == "1" || tanla == "2")
            {
                return tanla;
            }
            else
            {
                return Tanla2();
            }
        }

        // 4ta tanlash uchun
        public static string Tanla4()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3' || key.KeyChar == '4') && tanla.Length < 1)
                {
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            return tanla;

        }


        // 8ta tanlash uchun
        public static string Tanla8()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3' || key.KeyChar == '4' || key.KeyChar == '5' || key.KeyChar == '6' || key.KeyChar == '7' || key.KeyChar == '8') && tanla.Length < 1)
                {
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            return tanla;

        }

        // 10ta tanlash uchun
        public static string Tanla10()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3' || key.KeyChar == '4' || key.KeyChar == '5' || key.KeyChar == '6' || key.KeyChar == '7' || key.KeyChar == '8' || key.KeyChar == '9' || key.KeyChar == '0') && tanla.Length < 1)
                {
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            return tanla;

        }
        // 14ta tanlash uchun
        public static string Tanla14()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if (char.IsDigit(key.KeyChar) && tanla.Length < 2)
                {
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish

            return tanla;

        }

        // Boshqa summadagi pulni yechib olish uchun
        public static string OtherCash()
        {
            string summa = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (summa.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        summa = summa.Substring(0, summa.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if ((key.KeyChar >= 5000 || key.KeyChar <= 10000000) && summa.Length < 9)
                {
                    Console.Write(key.KeyChar);
                    summa += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || summa.Length == 0);

            return summa;
        }
        public static void PrintCash(string nom, int ProbelSoni1, double summa, int ProbelSoni2)
        {
            // Summa uzunligini aniqlash
            int summaLength = 0;

            int SummaSizeChange = Convert.ToInt32(summa);
            for (int i = 0; i < summa; i++)
            {
                SummaSizeChange /= 10;
                summaLength++;
                if (SummaSizeChange == 0) break;
            }
            string probel1 = "";
            for (int i = 0; i < ProbelSoni1 - nom.Length; i++)
            {
                probel1 += ' ';
            }
            string probel2 = "";
            for (int i = 0; i < ProbelSoni2 - summaLength; i++)
            {
                probel2 += ' ';
            }

            // Probellar soni bo'yicha qatorni tuzish
            string formattedSum = $"       |   {nom}{probel1}: {summa} UZS{probel2}";

            formattedSum += "|";
            Console.WriteLine(formattedSum);
        }

        public static int EnterNumber()
        {
            string tanla = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace tugmasini bosganda
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (tanla.Length > 0)
                    {
                        // O'xshash belgini consoldan o'chirib tashlash
                        Console.Write("\b \b");
                        tanla = tanla.Substring(0, tanla.Length - 1);
                    }
                }
                // Foydalanuvchi Enter tugmasini bosganda chiqish
                else if (char.IsDigit(key.KeyChar) && tanla.Length < 9)
                {
                    Console.Write(key.KeyChar);
                    tanla += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter || tanla.Length == 0); // Enter tugmasi bosilganda va parol uzunligi 0 bo'lganida davom etish
            int n = int.Parse(tanla);
            return n;

        }

    }
}
