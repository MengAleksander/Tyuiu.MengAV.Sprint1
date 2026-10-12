using System.Globalization;
using Tyuiu.MengAV.Sprint1.Task3.V10.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "3"},
{"{{HV}}", "10"},
{"{{TY}}", "Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране."},
{"{{TV}}", "Введите дробное число -> 23.6"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите дробное число: ");

string inp = Console.ReadLine().Trim().Replace(',', '.');

if (double.TryParse(
    inp,
    NumberStyles.Float,
    CultureInfo.InvariantCulture,
    out double num))
{
    Console.WriteLine($"{num} руб. — это {ds.NumberToMoney(num)}");
}
else
{
    Console.WriteLine("Некорректное число.");
}