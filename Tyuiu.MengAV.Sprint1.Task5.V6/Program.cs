using Tyuiu.MengAV.Sprint1.Task5.V6.Lib;

Console.WriteLine("Задание: 5");
Console.WriteLine("Вариант: 6");
Console.WriteLine("Вполнил: Менг А. В.");
Console.WriteLine("_________________________________________");

Console.Write("Введите номер дня года от 1 до 365: ");
int k = Convert.ToInt32(Console.ReadLine());

try
{
    int n = DataServies.DayNumber(k);
    string daynam = DataServies.DayName(n);

    Console.WriteLine($"n = {n}");
    Console.WriteLine($"{k}-й день года — это {daynam}.");
}
catch (ArgumentOutOfRangeException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
}