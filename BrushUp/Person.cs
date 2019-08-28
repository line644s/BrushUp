using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp
{
    public class Person
    {
        private string _name;
        private string _adress;

        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        public string Adress
        {
            get { return _adress; }
            set
            {
                CheckAdress(value);
                _adress = value;
            }
        }

        public Gender Gender { get; set; }

        private static void CheckName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is null or empty");
            }

            if (name.Length < 2)
            {
                throw new ArgumentException("Name must contain atleast 2 characters");
            }
        }


        private static void CheckAdress(string adress)
        {
            if (String.IsNullOrWhiteSpace(adress))
            {
                throw new ArgumentException("Adress is null or empty");
            }
        }

    }
    public enum Gender
    {
        Male, Female
    }
}
