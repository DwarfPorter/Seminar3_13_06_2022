// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x = Prompt("Введите X => ");
int y = Prompt("Введите Y =>");

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Одна из коорлдинат равна 0");
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 четверть");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}