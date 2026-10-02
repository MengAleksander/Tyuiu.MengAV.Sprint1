using Tyuiu.MengAV.Sprint1.Task2.V24.Lib;

Console.WriteLine("Задание: 2");
Console.WriteLine("Вариант: 24");
Console.WriteLine("Вполнил: Менг А. В.");

Console.Write("Введите первое целое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = DataServies.Kvadrat(x, y);

Console.WriteLine($"Квадрат разницы: {result}");