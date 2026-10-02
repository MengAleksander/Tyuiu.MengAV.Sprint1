using Tyuiu.MengAV.Sprint1.Task6.V8.Lib;

Console.WriteLine("Задание: 5");
Console.WriteLine("Вариант: 6");
Console.WriteLine("Вполнил: Менг А. В.");
Console.WriteLine("_________________________________________");

Console.Write("Введите текст: ");
string text = Console.ReadLine();

string res = DataServies.Word(text);

Console.WriteLine("Преобразованный текст:");
Console.WriteLine(res);