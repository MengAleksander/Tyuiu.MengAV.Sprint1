using Tyuiu.MengAV.Sprint1.Task4.V20.Lib;

Console.WriteLine("Задание: 4");
Console.WriteLine("Вариант: 20");
Console.WriteLine("Вполнил: Менг А. В.");
Console.WriteLine("_________________________________________");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

try
{
    double res = DataServies.Formula(x, y);

    Console.WriteLine($"Результат: {res:F3}");
}
catch (DivideByZeroException error)
{
    Console.WriteLine($"Ошибка: {error.Message}");
}