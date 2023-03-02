// Написать программу возведения числа А в целую стень B
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Number = ReadInt("Enter number: ");
int Rank = ReadInt("Enter rank: ");
int result = Number;
for (int i=1; i<Rank; i++)
{
    result=Number*result;
}
Console.WriteLine(result);