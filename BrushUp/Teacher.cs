using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp
{
    class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get { return _salary;}
            set
            {
                TjekSalary(value);
                _salary = value;
            }
        }

        public Teacher(string name, string adress, Gender gender)
        {
            Name = name;
            Adress = adress;
            Gender = gender;
        }

        private void TjekSalary(int salary)
        {
            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException($"the salary {salary} is too small");
            }
        }
    }
}
