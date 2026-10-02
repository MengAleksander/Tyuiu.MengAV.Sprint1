using Tyuiu.MengAV.Sprint1.Task1.V21.Lib;

Console.WriteLine("Задание: 1");
Console.WriteLine("Вариант: 21");
Console.WriteLine("Вполнил: Менг А. В.");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

try
{
    double result = DataServies.Yravnenie(x, y);

    Console.WriteLine($"Результат: {result}");
}
catch (DivideByZeroException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
} 