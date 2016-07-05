using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация класса Triangle: ");

            while (_isRepeat)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("{0,10} {1}", "1:", "Создать треугольник");
                Console.WriteLine("{0,10} {1}", "2:", "Очистить консоль");
                Console.WriteLine("{0,10} {1}", "3:", "Выйти");
                SelectAction();
            }
        }

        private static void SelectAction()
        {
            int selectedNumber = 0;
            int.TryParse(Console.ReadLine(), out selectedNumber);
            switch (selectedNumber)
            {
                case 1:
                    CreateTriangle();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    _isRepeat = false;
                    break;
            }
        }

        private static void CreateTriangle()
        {
            Console.WriteLine("Введите длины сторон A,B,C соответственно (например: 5 5 3):");
            string[] parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int a;
            int b;
            int c;
            if (int.TryParse(parameters[0], out a) && int.TryParse(parameters[1], out b) &&
                int.TryParse(parameters[2], out c))
            {
                if (CheckExistenceTriangle(a, b, c))
                {
                    Triangle triangle = new Triangle(a, b, c);
                    Console.WriteLine("Треугольник со сторонами A= {0},B= {1}, C= {2} создан.", triangle.A, triangle.B, triangle.C);
                    ShowInfoTriangle(triangle);
                }
                else
                    Console.WriteLine("Треугольник с такими сторонами не существует ");
            }
            else
            {
                Console.WriteLine("Введенные значения некорректны!");
            }
        }

        private static void ShowInfoTriangle(Triangle triangle)
        {
            Console.WriteLine("Периметр треугольника: {0:0.##} ", triangle.Perimeter);
            Console.WriteLine("Площадь треугольника: {0:0.##} ", triangle.Area);
        }

        private static bool CheckExistenceTriangle(int a, int b, int c)
        {
            bool isExist = false;

            if ((a < b + c) && (b < c + a) && (c < a + b))
                isExist = true;
            else
                isExist=false;

            return isExist;
        }
    }
}
