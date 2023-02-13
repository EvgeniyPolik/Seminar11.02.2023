int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

int AccermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else  if (m > 0 && n == 0)
        return AccermanFunc(m - 1, 1);
    else if (m > 0 && n > 0)
        return AccermanFunc(m - 1, AccermanFunc(m , n - 1));
    else
        throw new ArgumentException("Invalid argument");
}

var m = GetIntFromConsole("Введите m");
var n = GetIntFromConsole("Введите n");
Console.WriteLine($"Значение функции Аккермана: {AccermanFunc(m, n)}");