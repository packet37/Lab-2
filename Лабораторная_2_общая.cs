using Classes;
using System;

Console.WriteLine("Количество людей: ");
int n = int.Parse(Console.ReadLine());
Person[] Persons = new Person[n];

for (int i = 0; i < n; i++)
{
    Persons[i] = new Person();
    Persons[i].Read();
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Persons[i].Surname);
    Console.WriteLine(Persons[i].Name);
    Console.WriteLine(Persons[i].Age(Persons[i].BirthDate));
    Console.WriteLine(Persons[i].Gender);
}