using System;

namespace dz_1._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            Console.Write("Введите число от 1 до 100: ");
            int numer = Convert.ToInt32(Console.ReadLine());
            if (numer > 100 || numer < 1)
            {
                Console.WriteLine("Введено неверное число\n");
                return;
            }
            if (numer % 3 == 0)
                Console.Write("Fizz ");
            if (numer % 5 == 0)
                Console.Write("Buzz ");
            if (numer % 3 != 0 && numer % 5 != 0)
                Console.Write($"{numer}");
            Console.WriteLine();
            #endregion

            #region Задача 2
            Console.WriteLine("Введите число: ");
            int numer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите % который ищите: ");
            int proc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ответ = {numer2 * proc / 100}");
            #endregion

            #region Задача 3
            Console.WriteLine("Введите 1 число: ");
            string numer3_1 = Console.ReadLine();
            Console.WriteLine("Введите 2 число: ");
            string numer3_2 = Console.ReadLine();
            Console.WriteLine("Введите 3 число: ");
            string numer3_3 = Console.ReadLine();
            Console.WriteLine("Введите 4 число: ");
            string numer3_4 = Console.ReadLine();
            int numer3 = Convert.ToInt32(numer3_1 + numer3_2 + numer3_3 + numer3_4);
            Console.WriteLine($"Целое число: {numer3}");
            #endregion

            #region Задача 4
            Console.WriteLine("Введите шестизначное число: ");
            string numer4 = Console.ReadLine();
            if (numer4.Length != 6)
            {
                Console.WriteLine("Введено неверное число\n");
                return;
            }
            Console.WriteLine("Введите 1 число: ");
            int numer4_1 = Convert.ToInt32(Console.ReadLine());
            numer4_1--;
            Console.WriteLine("Введите 2 число: ");
            int numer4_2 = Convert.ToInt32(Console.ReadLine());
            numer4_2--;
            char mass2_4 = numer4[numer4_2];
            char mass1_4 = numer4[numer4_1];
            numer4 = numer4.Remove(numer4_1, 1).Insert(numer4_1, mass2_4.ToString());
            numer4 = numer4.Remove(numer4_2, 1).Insert(numer4_2, mass1_4.ToString());
            Console.WriteLine($"Результат: {numer4}");
            #endregion

            #region Задача 5
            Console.Write("Введите дату в формате DD.MM.YY: ");
            string date5 = Console.ReadLine();
            string date_d = date5[0].ToString();
            date_d += date5[1];
            string date_m = date5[3].ToString();
            date_m += date5[4];
            int num_d = Convert.ToInt32((date_d));
            int num_m = Convert.ToInt32((date_m));
            if ((num_m >= 1 && num_m <= 2) || num_m == 12)
                Console.Write("Winter ");
            else if (num_m >= 3 && num_m <= 5)
                Console.Write("Spring ");
            else if (num_m >= 6 && num_m <= 8)
                Console.Write("Summer ");
            else if (num_m >= 9 && num_m <= 11)
                Console.Write("Autumn ");
            int buf_5 = num_d % 7;
            switch (buf_5)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

            }
            #endregion

            #region Задача 6
            Console.Write("С - Цельсий, F - Фаренгейт: ");
            string type = Console.ReadLine();
            if (type != "F" && type != "C")
            {
                Console.WriteLine("Введено неверное значение\n");
                return;
            }
            Console.WriteLine("Введите кол-во градусов");
            double numer6 = Convert.ToDouble(Console.ReadLine());
            if (type == "F")
            {
                Console.Write($"F = {numer6}° ");
                double ces = (numer6 - 32) * 5 / 9;
                Console.Write($"C = {ces}° ");
            }
            else
            {
                Console.Write($"C = {numer6}° ");
                double far = (numer6 * 9 / 5) + 32;
                Console.Write($"F = {far}° ");
            }
            Console.WriteLine();
            #endregion

            #region Задача 7
            Console.Write("Введите 1 число: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int max = Convert.ToInt32(Console.ReadLine());
            if (min > max)
            {
                int buf = min;
                min = max;
                max = buf;
            }
            Console.Write("Все четные числа введенного диапазона: ");
            for (int i = min; i <= max; i += 2)
            {
                if (i % 2 != 0)
                    i++;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
