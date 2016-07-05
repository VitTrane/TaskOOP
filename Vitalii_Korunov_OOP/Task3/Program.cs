using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация класса User: ");

            while (_isRepeat)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("{0,10} {1}", "1:", "Создать пользователя");
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
                    CreateUser();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    _isRepeat = false;
                    break;
            }
        }

        private static void CreateUser()
        {
            Console.WriteLine("Введите информацию о пользователе (например: Пупкин Василий Борисович 22.07.1965):");
            string[] parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime dateBirth;
            if (DateTime.TryParse(parameters[3], out dateBirth))
            {
                User user = new User(parameters[0],parameters[1],parameters[2],dateBirth);
                Console.WriteLine("Пользователь {0} создан.", user);
                ShowInfoUser(user);
            }
            else
            {
                Console.WriteLine("Введенные значения некорректны!");
            }
        }

        private static void ShowInfoUser(User user)
        {
            Console.WriteLine("Дата рождения пользователя: " + user.DateBirth.ToLongDateString());
            Console.WriteLine("Возраст пользователя: " + user.Age);
        }
    }
}
