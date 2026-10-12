using Tyuiu.MengAV.Sprint1.Task5.V6.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "5"},
{"{{HV}}", "6"},
{"{{TY}}", "Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от того, на какой день недели (понедельник, вторник,..., воскресенье) приходится k-й день невисокосного года, в котором 1 января – понедельник."},
{"{{TV}}", "целое от 1 до 365"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите номер дня года: ");
int k = Convert.ToInt32(Console.ReadLine());

string[] days =
{
    "понедельник",
    "вторник",
    "среда",
    "четверг",
    "пятница",
    "суббота",
    "воскресенье"
};

try
{
    int n = ds.Calculate(k);
    Console.WriteLine($"{k}-й день года — это {days[n - 1]}.");
}
catch (ArgumentOutOfRangeException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
}