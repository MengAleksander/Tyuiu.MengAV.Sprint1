using Tyuiu.MengAV.Sprint1.Task4.V20.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "4"},
{"{{HV}}", "20"},
{"{{TY}}", "Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой."},
{"{{TV}}", "(1 + x) / |x - sqrt(2 + y)|"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

try
{
    double res = ds.Calculate(x, y);

    Console.WriteLine($"Результат: {res:F3}");
}
catch (DivideByZeroException error)
{
    Console.WriteLine($"Ошибка: {error.Message}");
}