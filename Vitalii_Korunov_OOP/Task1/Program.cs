using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация класса Round: ");

            while (_isRepeat)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("{0,10} {1}", "1:", "Создать окружность");
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
                    CreateRound();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    _isRepeat = false;
                    break;
            }
        }

        private static void CreateRound()
        {
            Console.WriteLine("Введите координаты X,Y и радиус соответственно (например: 5 5 3):");
            string[] parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int x;
            int y;
            int radius;
            if (int.TryParse(parameters[0], out x) && int.TryParse(parameters[1], out y) &&
                int.TryParse(parameters[2], out radius) && radius > 0)
            {
                Round round = new Round(x, y, radius);
                Console.WriteLine("Круг с координатам ({0},{1}) и радиусом {2} создан.", round.X, round.Y, round.Radius);
                ShowInfoRound(round);
            }
            else
            {
                Console.WriteLine("Введенные значения некорректны!");
            }            
        }

        private static void ShowInfoRound(Round round)
        {
            Console.WriteLine("Длина круга: {0:0.##} ", round.Length);
            Console.WriteLine("Площадь круга: {0:0.##} ", round.Area);
        }
    }
}
