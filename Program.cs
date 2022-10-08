// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и определяет, является ли оно палиндромом
// 1 способ, математический
/*
Console.WriteLine("Введите пятизначное число:  ");
int N = int.Parse(Console.ReadLine()!); 
int number1 = N/10000;
int number2 = N/1000%10;
int number4 = N/10%10;
int number5 = N%10;

if(N < 10000 || N > 99999)
{
    Console.WriteLine("Введенное число не пятизначное");
}
else
{
    if(number1 == number5 && number2 == number4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
*/

// 2 способ решения той же задачи через строки
/*
Console.WriteLine("Введите число:  ");
String N = Console.ReadLine()!;
if (N.Length == 5)
{
    int num1 = Convert.ToInt32(N[0]);
    int num2 = Convert.ToInt32(N[1]);
    int num4 = Convert.ToInt32(N[3]);
    int num5 = Convert.ToInt32(N[4]);
    if (num1 == num5 && num2 == num4)
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
Console.WriteLine("Введите координату x1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y1");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z1");
int number3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x2");
int number4 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2");
int number5 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z2");
int number6 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((number4 - number1),2) + Math.Pow((number5 - number2),2) + Math.Pow((number6 - number3),2));
Console.WriteLine($"{result:f2}");
*/

// Задача 23
// Напишите прорамму, которая принимает на вход число N, и выдает таблицу кубов от 1 до N
/*
Console.WriteLine("Введите число:  ");
int N = int.Parse(Console.ReadLine()!); 
int number = 1;
if(N < 0)
{
    Console.WriteLine("Ваше число отрицательное");
}
else
{
    while(number < N)
    {
        Console.Write($"{Math.Pow(number, 3)}, ");
        number++;
    }
    Console.Write($"{Math.Pow(number, 3)} ");
}
*/
