using System;
using Model;

namespace Console
{
    class Program
    {
        static IFigure CreateCircle()
        {
            while (true)
            {
                System.Console.WriteLine("Введите радиус");
                string r = System.Console.ReadLine();

                if (string.IsNullOrEmpty(r)) continue;

                if (double.TryParse(r, out double radius))
                {
                    try
                    {
                        return new Circle(radius);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }

                }
                else System.Console.WriteLine("Введите численное положительное значение");
            }
        }

        static IFigure CreateTriangle()
        {
            while (true)
            {
                System.Console.WriteLine("Введите a");
                string a = System.Console.ReadLine();

                System.Console.WriteLine("Введите b");
                string b = System.Console.ReadLine();

                System.Console.WriteLine("Введите c");
                string c = System.Console.ReadLine();

                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c)) continue;

                if (double.TryParse(a, out double _a) && double.TryParse(b, out double _b) && double.TryParse(c, out double _c))
                {
                    try
                    {
                        return new Triangle(_a, _b, _c);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }

                }
                else System.Console.WriteLine("Введите численное положительное значение");
            }
        }

        static IFigure CreateRectangle()
        {
            while (true)
            {
                System.Console.WriteLine("Введите a");
                string a = System.Console.ReadLine();

                System.Console.WriteLine("Введите b");
                string b = System.Console.ReadLine();

                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) continue;

                if (double.TryParse(a, out double _a) && double.TryParse(b, out double _b))
                {
                    try
                    {
                        return new Rectangle(_a, _b);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }

                }
                else System.Console.WriteLine("Введите численное положительное значение");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Вычисление площади.");
                System.Console.WriteLine("Выберите фигуру");
                System.Console.WriteLine("1 - круг");
                System.Console.WriteLine("2 - треугольник");
                System.Console.WriteLine("3 - прямоугольник");
                System.Console.WriteLine("4 - выход");

                char motionType = System.Console.ReadKey(true).KeyChar;

                IFigure figure = null;

                switch (motionType)
                {
                    case '1':
                        figure = CreateCircle();
                        break;
                    case '2':
                        figure = CreateTriangle();
                        break;
                    case '3':
                        figure = CreateRectangle();
                        break;
                    case '4':
                        break;
                    default:
                        continue;
                }

                System.Console.WriteLine(figure?.ToString());

                System.Console.WriteLine("Для завершения программы нажмите любую клавишу..");
                System.Console.ReadLine();
                break;
            }
        }
    }
}
