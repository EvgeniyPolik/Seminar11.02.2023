int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

int GetPower(int a, int b)
{
    if (b == 0)
        return 1;
    return a * GetPower(a, b - 1);
}

var a = GetIntFromConsole("Введите основание степени: ");
var b = GetIntFromConsole("Введите показатель степени: ");
Console.WriteLine($"Число {a} в степени {b} равно: {GetPower(a, b)}");
