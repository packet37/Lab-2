using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Prism
    {
        public Prism(string name, double a, double b, double c, double h)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        public Prism()
        {
        }

        public string name { set; get; }
        public double a { set; get; }
        public double b { set; get; }
        public double c { set; get; }
        public double h { set; get; }
        public double V()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public double Area()
        {
            return h*(a+b+c);

        }
        public void Read()
        {
            Console.WriteLine("Введите название:  ");
            name = Console.ReadLine();
            Console.WriteLine("Введите первое ребро");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе ребро");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье ребро");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            h = double.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Форма фигуры: {name}");
            Console.WriteLine($"Объем: {V()}");
            Console.WriteLine($"Площадь: {Area()}");

        }
    }
}