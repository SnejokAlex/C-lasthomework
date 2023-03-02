// Найти сумму цифр числа
Console.WriteLine("Enter your number");
int number = int.Parse(Console.ReadLine());
int result = 0;
while (number >9)
{
     result=result+(number%10);
     number=number/10;
}
result=result+number;
Console.WriteLine(result);