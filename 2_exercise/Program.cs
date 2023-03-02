// Найти сумму элементов от M до N, N и M заданы
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FirstNumber = ReadInt("Enter first number: ");
int SecondNumber = ReadInt("Enter second number: ");
int result = 0;
if (FirstNumber<SecondNumber)
{
    while (FirstNumber<=SecondNumber)
    {
        result=FirstNumber+result;
        FirstNumber++;
    }
}
else 
{
    while (FirstNumber>=SecondNumber)
    {
        result=SecondNumber+result;
        SecondNumber++;
    }
}
    Console.WriteLine(result);