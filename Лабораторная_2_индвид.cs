using ConsoleApp7;


Prism figure1 = new Prism();
Prism figure2 = new Prism("Вторая фигура", 3, 4, 5, 5);

figure1.Read();
figure1.Print();


figure2.Print();

if (figure1.V() > figure2.V())
{
    Console.WriteLine($"Фигура с наибольшим объемом {figure1.name}");
}

else if (figure1.V() < figure2.V())
{
    Console.WriteLine($"Фигура с наибольшим объемом {figure2.name}");
}
else
{
    Console.WriteLine("Объемы одинаковы");
}

double Area1 = figure1.Area();
double Area2 = figure2.Area();

if (Math.Abs(100 - Area1) > Math.Abs(100 - Area2))
{
    Console.WriteLine($"Площадь {figure1.name} ближе к 100");
}
else if (Math.Abs(100 - Area2) > Math.Abs(100 - Area1))
{
    Console.WriteLine($"Площадь {figure2.name} ближе к 100");
}

//номер 2 

Console.WriteLine("Введите кол-во фигур:  ");
int n = Convert.ToInt32(Console.ReadLine());

Prism[] figures = new Prism[n];
for (int i = 0; i < n; i++)
{
    figures[i] = new Prism();
    figures[i].Read();
}

//a самая длинная надпись 

int max = 0;

for (int i = 1; i < n; i++)
{
    if (figures[i].name.Length > figures[max].name.Length)
    {
        max = i;
    }
}

figures[max].Print();

//б увеличение линейно на 2

Prism bigfigure = new Prism("Новая фигура", figures[figures.Length - 1].a * 2, figures[figures.Length - 1].b * 2, figures[figures.Length - 1].c * 2, figures[figures.Length - 1].h * 2);

bigfigure.Print();

Console.WriteLine($"{bigfigure.a} {bigfigure.b} {bigfigure.c} {bigfigure.h}");

//c все площади в массив 

Console.WriteLine("Все площади фигур в массиве: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(figures[i].name + " поверхности " + figures[i].Area());
}

//д добавить MIN к минимальной площади 

int mmin = 0;
for (int i = 1; i < n; i++)
{
    if (figures[i].Area() < figures[mmin].Area())
    {
        mmin = i;
    }
}

figures[mmin].name = " MIN " + figures[mmin].name;
Console.WriteLine($"Фигура с наименьшей площадью: {figures[mmin].name}");


//e кол-во площадей меньше 15

int count = 0;
for (int i = 0; i < n; i++)
{
    if (figures[i].Area() > 15)
    {
        count++;
    }
}
Console.WriteLine($"Площади больше 15: {count}");

//f все объемы в массив 

Console.WriteLine("Все объемы в массиве");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(figures[i].name + " объем " + figures[i].V());
}

//g сумма всех объемов

double allVolume = 0;
for (int i = 0; i < n; i++)
{
    allVolume = figures[i].V() + allVolume;

}
Console.WriteLine($"Сумма всех объемов: {allVolume}");