/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
string a = Console.ReadLine();

int SumNumbers()
{
    int sum=0;

    for (int i=0; i < a.Length; i++)
    {
        sum+=Convert.ToInt32(a[i].ToString());
    }
    return sum;
} 

Console.WriteLine(SumNumbers());
