// Показать натуральные числа от M до N, N и M заданы
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FirstNumber = ReadInt("Enter first number: ");
int SecondNumber = ReadInt("Enter second number: ");
if (FirstNumber<SecondNumber)
{
    while (FirstNumber<=SecondNumber)
    {
        Console.Write($"{FirstNumber} ");
        FirstNumber++;
    }
}
else 
{
    while (FirstNumber>=SecondNumber)
    {
        Console.Write($"{SecondNumber} ");
        SecondNumber++;
    }
}