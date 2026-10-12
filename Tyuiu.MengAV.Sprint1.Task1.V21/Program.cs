using Tyuiu.MengAV.Sprint1.Task1.V21.Lib;

DataServies ds = new DataServies();

string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "1"},
{"{{HV}}", "21"},
{"{{TY}}", "Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле (x*y)/(3+y) и печатает его на экране."},
{"{{TV}}", "(x*y)/(3+y)"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

try
{
    double result = ds.Calculate(x, y);

    Console.WriteLine($"Результат:{result}");
}
catch (DivideByZeroException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
} 