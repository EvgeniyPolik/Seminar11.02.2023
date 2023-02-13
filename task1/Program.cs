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

var n = GetIntFromConsole("Введите N");
Console.WriteLine($"Натуральные числа от 1 до {n}");
PrintDigit(1, n);