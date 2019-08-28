using System;

namespace BrushUp
{
    /// <summary>
    /// Parm Name, Adress, Semester, Enum Køn,
    /// Name, at least 2 characters
    /// Address, not null
    /// Semester, under 1 and over 8
    /// Gender, Enum with values Male and Female
    /// </summary>
    public class Student : Person
    {
        
        private int _semester;


        public int Semester
        {
            get { return _semester;}
            set
            {
                CheckSemester(value);
                _semester = value;
            }
        }
        

        public Student(string name, string adress, int semester, Gender gender)
        {
            Name = name;
            Adress = adress;
            Semester = semester;
            Gender = gender;
        }

        private static void CheckSemester(int semester)
        {
            if (semester < 1 || semester > 8)
            {
                throw new ArgumentOutOfRangeException($"semester {semester} is not a real semester");
            }
        }
    }
}
