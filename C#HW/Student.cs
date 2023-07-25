using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW
{
    internal class Student
    {

        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, double point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;

        }

        public void GetNameAndSurname()
        {
            //return Name;
            //return Surname;
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
        }
        public void GetAllValue()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Group);
            Console.WriteLine(Point);
            Console.WriteLine(IsGraduated);

            if (IsGraduated)
            {
                Console.WriteLine("Mezun olub");
            }
            else
            {
                Console.WriteLine("Mezun  olmayib");
            }
        }

        public void ReducePoint()
        {
            if (Point > 80)
            {
                Console.WriteLine("Ikinci imtahana gire bilersiniz");
            }
            else
            {
                Console.WriteLine("IKinci imtahana gire bilmezsiniz");
            }
        }
    }
}
