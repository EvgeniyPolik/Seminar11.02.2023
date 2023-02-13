int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

void PrintMyFibanacci(int a, int b, int counter, int stopValue)
{
    if (counter == stopValue)
    {
        Console.Write(a + b);
        return;
    }
    Console.Write(a + b);
    Console.Write(" ");
    PrintMyFibanacci(b, a + b, ++counter, stopValue);
}

var n = GetIntFromConsole("Введите количество чисел: ");
var a = GetIntFromConsole("Введите первое число: ");
var b = GetIntFromConsole("Введите второе число: ");
Console.WriteLine("Полученный ряд чисел:");
PrintMyFibanacci(a, b, 1, n);