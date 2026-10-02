using System.Globalization;
using Tyuiu.MengAV.Sprint1.Task3.V10.Lib;

Console.WriteLine("Задание: 3");
Console.WriteLine("Вариант: 10");
Console.WriteLine("Вполнил: Менг А. В.");

Console.Write("Введите дробное число: ");

string inp = Console.ReadLine().Replace(',', '.');

decimal num = decimal.Parse(inp,CultureInfo.InvariantCulture);

decimal mon = DataServies.Number(num);
int rub = DataServies.Rubles(num);
int kop = DataServies.Kopecks(num);

Console.WriteLine($"{mon:F3} руб. — это " + $"{rub} руб. {kop:D2} коп.");