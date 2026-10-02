using Tyuiu.MengAV.Sprint1.Task7.V18.Lib;

Console.WriteLine("Задание: 5");
Console.WriteLine("Вариант: 6");
Console.WriteLine("Вполнил: Менг А. В.");
Console.WriteLine("_________________________________________");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = DataServies.Formula(x, y);

Console.WriteLine($"Результат: {res:F3}");