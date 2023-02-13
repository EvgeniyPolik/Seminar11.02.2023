int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

void GetSum(int curentValue, int endValue, int sum)
{
    if (curentValue > endValue)
    {
        Console.WriteLine(sum);
        return;
    }       
    sum += curentValue;
    GetSum(++curentValue, endValue, sum);
}

var m = GetIntFromConsole("Введите M");
var n = GetIntFromConsole("Введите N");
Console.WriteLine($"Сумма чисел от {m} до {n}:");
GetSum(m, n, 0);