// Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.WriteLine("Введите число до которого хотите знать промежуток");
int N = Convert.ToInt32(Console.ReadLine());
int m = N;
if (m < 0)
{
    m =-1*m;
}
void Range(int N, int m)
{
if (m == -1)
{
    return;
}
Console.Write(m +" ");
Range(N,m-1);
}
Range(N,m);
*/
//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
Console.WriteLine("Введите числа промежутки между которыми хотите знать ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int N = 0;
int M = 0;
if (A > B)
{
    N = A;
    M= B;
}
else
{
    N= B;
    M = A;
}
int sum = 0;
int TheIntervalNM (int N, int M){
if (M < N)
{
sum += M;
TheIntervalNM(N,M+1);
    return sum; 
}
return sum;
}
Console.WriteLine($"Сумма целых чисел от  {M}    до {N}   равна {TheIntervalNM(N,M)+N}");
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите числo M для вычисления функции Аккурмана ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N для вычисления функции Аккермана ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для чисел {m} и {n}  равна");
//string ackermannResult = Convert.ToString(ackermann(m,n));
Console.WriteLine(ackermann(m,n));
int ackermann(int m, int n) {
    double m = Convert.ToDouble(m1);
    double n = Convert.ToDouble(n1);
    while(m != 0) {
        if(n == 0) {
            n = 1;
        } else {
            n = ackermann(m, n - 1);
        }
        m--;
    }
    return n + 1;
}