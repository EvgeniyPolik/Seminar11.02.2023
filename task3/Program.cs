int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

void PrintDigit(int curentValue, int endValue)
{
    if (curentValue > endValue)
    {
        Console.WriteLine();
        return;
    }
        
    Console.Write(curentValue);
    Console.Write(" ");
    PrintDigit(++curentValue, endValue);
}

var m = GetIntFromConsole("Введите M");
var n = GetIntFromConsole("Введите N");
Console.WriteLine($"Натуральные числа от {m} до {n}");
PrintDigit(m, n);