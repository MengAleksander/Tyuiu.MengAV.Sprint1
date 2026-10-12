using Tyuiu.MengAV.Sprint1.Task2.V24.Lib;

DataServies ds = new DataServies();

string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "2"},
{"{{HV}}", "24"},
{"{{TY}}", "Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране."},
{"{{TV}}", "Заданы два числа. Вычислить квадрат их разницы."}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);

Console.Write("Введите первое целое число: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int valueTwo = Convert.ToInt32(Console.ReadLine());

int result = ds.CalculateDiffSquare(value, valueTwo);

Console.WriteLine($"Квадрат разницы: {result}");