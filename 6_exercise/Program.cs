// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int FirstNumber = ReadInt("Enter first number: ");
int SecondNumber = ReadInt("Enter second number: ");
int N = ReadInt("Enter size: ");
int result = 0;
for (int i=0; i<N; i++)
{
   result=FirstNumber+SecondNumber;
   FirstNumber=SecondNumber;
   SecondNumber=result;
   Console.WriteLine(result);
}
