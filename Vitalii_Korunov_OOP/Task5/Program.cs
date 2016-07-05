using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Делегат методов создания объекта
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public delegate void CreateObjectDelegate(int x,int y);

    class Program
    {
        private static bool _isRepeat = true;
        private static List<IDraw> _drawObjects = new List<IDraw>();

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("{0,10} {1}", "1:", "Создать линию");
                Console.WriteLine("{0,10} {1}", "2:", "Создать окружность");
                Console.WriteLine("{0,10} {1}", "3:", "Создать круг");
                Console.WriteLine("{0,10} {1}", "4:", "Создать кольцо");
                Console.WriteLine("{0,10} {1}", "5:", "Создать прямоугольник");
                Console.WriteLine("{0,10} {1}", "6:", "Отрисовать объекты");
                Console.WriteLine("{0,10} {1}", "7:", "Очистить консоль");
                Console.WriteLine("{0,10} {1}", "8:", "Выйти");

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
                    CreateObject(CreateLine);
                    break;
                case 2:
                    CreateObject(CreateRound);
                    break;
                case 3:
                    CreateObject(CreateCircle);
                    break;
                case 4:
                   CreateObject(CreateRing);
                    break;
                case 5:
                    CreateObject(CreateRectangle);
                    break;
                case 6:
                    DrawObjects();
                    break;
                case 7:
                    Console.Clear();
                    break;
                case 8:
                    _isRepeat = false;
                    break;
            }
        }

        /// <summary>
        /// Отрисовывает объекты
        /// </summary>
        private static void DrawObjects() 
        {
            foreach (var obj in _drawObjects)
            {
                Console.WriteLine();
                obj.Draw();
            }
        }

        /// <summary>
        /// Создает объект
        /// </summary>
        private static void CreateObject(CreateObjectDelegate func)
        {
            Console.WriteLine("Введите координаты X,Y (например: 5 5):");
            string[] parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int x;
            int y;
            if (int.TryParse(parameters[0], out x) && int.TryParse(parameters[1], out y))
            {
                func(x, y);
            }
            else
            {
                Console.WriteLine("Введенные значения некорректны!");
            }
        }

        /// <summary>
        /// Создает линию
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        private static void CreateLine(int x,int y)
        {
            Line line = new Line(x, y);
            _drawObjects.Add(line);
            Console.WriteLine("Линия с координатам ({0},{1}) создана.", line.X, line.Y);
        }

        /// <summary>
        /// Создает окружность
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        private static void CreateRound(int x, int y)
        {
            Round round = new Round(x, y);
            _drawObjects.Add(round);
            Console.WriteLine("Окружность с координатам ({0},{1}) и радиусом {2} создана.", round.X, round.Y, round.Radius);
        }

        /// <summary>
        /// Создает круг
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        private static void CreateCircle(int x, int y)
        {
            Circle circle = new Circle(x, y);
            _drawObjects.Add(circle);
            Console.WriteLine("Круг с координатам ({0},{1}) и радиусом {2} создан.", circle.X, circle.Y, circle.Radius);
        }

        /// <summary>
        /// Создает кольцо
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        private static void CreateRing(int x, int y)
        {
            Ring ring = new Ring(x, y);
            _drawObjects.Add(ring);
            Console.WriteLine("Кольцо с координатам ({0},{1}) и радиусом {2} создано.", ring.X, ring.Y,ring.Radius);
        }

        /// <summary>
        /// Создает прямоугольник
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        private static void CreateRectangle(int x, int y)
        {
            Rectangle rectangle = new Rectangle(x,y);
            _drawObjects.Add(rectangle);
            Console.WriteLine("Прямоугольник с координатам ({0},{1}) создан.", rectangle.X, rectangle.Y);
        }
    }
}
