using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'M' | value == 'F' | value == 'm' | value == 'f') gender = value; }
        }
        public Person()
        {

        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthDate + " " + gender;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name}  Фамилия: {Surname}  Возраст: {Age(BirthDate)} Пол: {gender}");
        }
        public void Read()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Введите дату рождения: ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите пол: ");
            Gender = char.Parse(Console.ReadLine());
        }
        public int Age(DateTime birthDay)
        {
            int age = DateTime.Now.Year - birthDay.Year;

            if (DateTime.Now.Day < birthDay.Day)
            {
                if (DateTime.Now.Month < birthDay.Month)
                {
                    age--;
                }
            }

            return age;
        }

    }
}