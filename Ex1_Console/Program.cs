using System;
using System.Collections.Generic;

namespace Ex1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Function> func = new List<Function>();

            bool input = true;

            while (input)
            {
                int c = 0;
                try
                {
                    Console.WriteLine("Выберите функцию:\n1 - Прямая\n2 - парабола\n3 - гипербола\n4 - продолжить");
                    c = int.Parse(Console.ReadLine());


                    switch (c)
                    {
                        case 1:
                            double l_a, l_b;
                            Console.Write("Введите коэффициент a: ");
                            l_a = double.Parse(Console.ReadLine());

                            Console.Write("Введите коэффициент b: ");
                            l_b = double.Parse(Console.ReadLine());

                            func.Add(new Line(l_a, l_b));
                            break;
                        case 2:
                            double k_a, k_b, k_c;
                            Console.Write("Введите коэффициент a: ");
                            k_a = double.Parse(Console.ReadLine());

                            Console.Write("Введите коэффициент b: ");
                            k_b = double.Parse(Console.ReadLine());

                            Console.Write("Введите коэфициент c: ");
                            k_c = double.Parse(Console.ReadLine());

                            func.Add(new Kub(k_a, k_b, k_c));
                            break;
                        case 3:
                            double p_a, p_b;
                            Console.Write("Введите коэффициент a: ");
                            p_a = double.Parse(Console.ReadLine());

                            Console.Write("Введите коэффициент b: ");
                            p_b = double.Parse(Console.ReadLine());

                            func.Add(new Hyperbola(p_a, p_b));
                            break;
                        case 4:
                            input = false;
                            break;
                        default:
                            throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Неверный формат ввода данных!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            double x = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите точку x: ");
                    x = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\tФункция\t\tX\tY");
            foreach (Function item in func)
            {
                Console.WriteLine($"\t{item.name}\t{x}\t{item.Calculate(x)}");
            }
        }
    }
}
