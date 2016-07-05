using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация класса Employee: ");

            while (_isRepeat)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("{0,10} {1}", "1:", "Создать работника");
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
                    CreateEmployee();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    _isRepeat = false;
                    break;
            }
        }

        private static void CreateEmployee()
        {
            Console.WriteLine("Введите информацию о пользователе (например: Пупкин Василий Борисович 22.07.1965 Слесарь):");
            string[] parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime dateBirth;
            if (DateTime.TryParse(parameters[3], out dateBirth))
            {
                Employee employee = new Employee(parameters[0], parameters[1], parameters[2], dateBirth,parameters[4],0);
                Console.WriteLine("Работник {0} создан.", employee);
                ShowInfoEmployee(employee);                   
            }
            else
            {
                Console.WriteLine("Введенные значения некорректны!");
            }
        }

        private static void ShowInfoEmployee(Employee employee) 
        {
            Console.WriteLine("Должность: " + employee.Post);
            Console.WriteLine("Стаж работы: {0} лет ", employee.WorkExperience);
            Console.WriteLine("Дата рождения: " + employee.DateBirth.ToLongDateString());
            Console.WriteLine("Возраст: " + employee.Age); 
        }
    }
}
