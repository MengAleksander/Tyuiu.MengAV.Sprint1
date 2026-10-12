using Tyuiu.MengAV.Sprint1.Task0.V8.Lib;

DataServies ds = new DataServies();

string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "0"},
{"{{HV}}", "8"},
{"{{TY}}", "Написать программу, которая вычисляет выражение 15/2/4 и печатает результат на экране."},
{"{{TV}}", "15/2/4"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
Console.WriteLine(ds.Calculate());
Console.ReadKey();