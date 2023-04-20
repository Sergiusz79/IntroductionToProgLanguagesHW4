// Задача 27: 
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//Например:
//452   ->  11
// 82   ->  10
// 9012 ->  12

int a;

Console.WriteLine("Please enter number: ");
    while (!int.TryParse(Console.ReadLine(), out a))
    {
    Console.WriteLine("It's not a number! ");
    }

int sum=0;
int lgth = (int) Math.Log10(a)+1;

for (int count = 0; lgth > count; count++)
{
    int a1 = a / (int) Math.Pow(10, count);
    sum += a1 % 10;
}

    Console.WriteLine($"The sum of the digits in a number {sum} !");
