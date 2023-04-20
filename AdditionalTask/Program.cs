// Программа принимает на вход длины сторон прямоугольника (A B) и квадрата (С)
//Узнать сколько данных квадратов поместится внутри даного прямоугольника


int a, b, c;
Console.WriteLine("Please enter the lengths of sides A and B of the rectangle: ");
CheckReckt();

Console.WriteLine("Please enter the length of the C side of the square: ");
CheckSquare();

int l = a / c; 
int w = b / c;
int am = l * w;

Console.WriteLine($" {am} squares will fit in a given rectangle!");





void CheckReckt()
{
    while (!int.TryParse(Console.ReadLine(), out a))
    {
    Console.WriteLine("It's not a number! ");
    }
    while (!int.TryParse(Console.ReadLine(), out b))
    {
    Console.WriteLine("It's not a number! ");
    }
}

void CheckSquare()
{
    while (!int.TryParse(Console.ReadLine(), out c))
    {
    Console.WriteLine("It's not a number! ");
    }
}