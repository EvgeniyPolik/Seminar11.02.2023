int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

void GetSum(int curentValue, int sum)
{
    if (curentValue == 0)
    {
        Console.WriteLine(sum);
        return;
    }
    int value = curentValue % 10;
    sum += value;
    GetSum(curentValue / 10, sum);
}

var n = GetIntFromConsole("Введите Число");
GetSum(n, 0);