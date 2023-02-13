int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

void PrintDigit(int curentValue)
{
    if (curentValue == 0)
    {
        Console.WriteLine();
        return;
    }
        
    Console.Write(curentValue);
    Console.Write(" ");
    PrintDigit(--curentValue);
}

var n = GetIntFromConsole("Введите N");
Console.WriteLine($"Натуральные числа от {n} до 1");
PrintDigit(n);
