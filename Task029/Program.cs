// Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.
// Например:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int x = int.Parse(Console.ReadLine());
// int lgth = (int) Math.Log10(x);
// int sum=0;
// for (int i=lgth; i>=0; i--)
// {
//     sum+=x/(int)Math.Pow(10.0,i);
//     x=x%(int)Math.Pow(10.0,i);

//     Console.WriteLine($" sum = {sum}");

//     Console.WriteLine($" x = {x}");
// }
// Console.WriteLine(sum);

Console.WriteLine("Please enter number: ");
int lgth = 0;
    do 
    {
        int x = int.Parse(Console.ReadLine());
        lgth = (int) Math.Log10(x);
        if (lgth != 4) {Console.WriteLine("It's not five-digits number! ");}
        
    }
    while (lgth != 4);
Console.WriteLine("It's Super! ");