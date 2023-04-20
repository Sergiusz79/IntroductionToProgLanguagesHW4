// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a, b;
for (;;)
{
    Console.WriteLine("Please enter number: ");
    while (!int.TryParse(Console.ReadLine(), out a))
    {
    Console.WriteLine("It's not a number! ");
    }

    Console.WriteLine("Please enter degree number: ");    
    while (!int.TryParse(Console.ReadLine(), out b))
    {
    Console.WriteLine("It's not a number! ");
    }
    double pow = Math.Pow(a , b);

Console.WriteLine($" Number {a} to the power of {b} = {pow} ! ");
}



