using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Employee : User
    {
        private const int DEFAULT_WORK_EXPERIENCE = 0;

        private string _post;
        private int _workExperience;

        public int WorkExperience
        {
            get { return _workExperience; }
            set { _workExperience = value; }
        }

        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }

        public Employee(string secondName, string name, string patronymic, DateTime dateBirth)
            : base(secondName, name, patronymic, dateBirth)
        {
            _workExperience = DEFAULT_WORK_EXPERIENCE;
        }

        public Employee(string secondName, string name, string patronymic,
            DateTime dateBirth, string post, int workExperience)
            : base(secondName, name, patronymic, dateBirth)
        {
            _post = post;
            _workExperience = workExperience;
        }
    }
}
