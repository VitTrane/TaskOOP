using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class User
    {
        private string _name;
        private string _secondName;
        private string _patronymic;
        private int _age;
        private DateTime _dateBirth;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public int Age
        {
            get { return _age; }
        }

        public DateTime DateBirth
        {
            get { return _dateBirth; }
            set 
            {
                CalculateAge(value);
                _dateBirth = value; 
            }
        }

        public User(string secondName, string name, string patronymic, DateTime dateBirth)
        {
            _name = name;
            _secondName = secondName;
            _patronymic = patronymic;
            _dateBirth = dateBirth;
            CalculateAge(dateBirth);
        }

        private void CalculateAge(DateTime dateBirth) 
        {
            int years = DateTime.Now.Year - dateBirth.Year;
            if (DateTime.Now.Month < dateBirth.Month || (DateTime.Now.Month == dateBirth.Month && DateTime.Now.Day < dateBirth.Day))
                years--;

            _age = years;
        }

        public override string ToString()
        {
            string info = _secondName + " " + _name + " " + _patronymic;
            return info;
        }
    }
}
