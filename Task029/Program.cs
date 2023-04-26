// Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.
// Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Используй рандомные числа в пределах (0-1000)



int[] array = new int [8];

FillArray(array);

PrintArray(array);



void FillArray(int[] array)                          
{
int index = 0;                   
    while (index < array.Length)
    {
    array[index] = new Random().Next(0, 1000); 
    index++;                           
    }
}

void PrintArray(int[] array)
{
int index = 0;
    while (index < array.Length)
    {
    Console.Write($" {array[index]}");
    index++;
    }
}
