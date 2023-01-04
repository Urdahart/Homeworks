// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное М");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное N");
int n=Convert.ToInt32(Console.ReadLine());

int Ackermann(int m1,int n1)
{
    if (m1==0) return n1+1;
    if ((m1!=0)&&(n1==0)) return Ackermann(m1-1,1);
    else return Ackermann(m1-1,Ackermann(m1,n1-1));
}
Console.WriteLine($"A({m},{n}) = "+Ackermann(m,n));