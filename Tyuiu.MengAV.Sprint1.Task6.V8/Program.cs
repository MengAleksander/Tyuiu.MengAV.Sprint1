using Tyuiu.MengAV.Sprint1.Task6.V8.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "6"},
{"{{HV}}", "8"},
{"{{TY}}", "Написать программу: пользователь вводит текст. Напечатать все слова, перенеся их первую букву в конец."},
{"{{TV}}", "текст"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите текст: ");
string value = Console.ReadLine();

string res = ds.MoveLetterToEnd(value);

Console.WriteLine("Преобразованный текст:");
Console.WriteLine(res);