//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.WriteLine("Enter N: ");
int N=int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));
string PrintNumbers(int start, int end)
{
    if (start==end) return start.ToString();
    return(start +" "+PrintNumbers(start-1, end));
}
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.WriteLine("Enter M: ");
int M=int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter N: ");
int N=int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M,N));
int PrintNumbers(int start, int end)
{
    if (start==end) return start;
    return(start +=PrintNumbers(start+1, end));
}
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Enter 2 positive numbers: ");
int m=InputInt("Enter M: ");
int n=InputInt("Enter N: ");
Console.WriteLine($"A({m}, {n})={Akkierman(m,n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkierman(int m, int n)
{
    if(m==0)
    return n+1;
    if(m>0 && n==0)
    return Akkierman(m-1,1);
    else
    return Akkierman(m-1, Akkierman(m,n-1));
}