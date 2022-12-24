/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число");
string a=Convert.ToString(Console.ReadLine());
int length = a.Length;
int i=0;

while (i < length/2)
    { 
        if (a[i]==a[length-i-1]) i++;
        else 
            {
                Console.WriteLine("Число не является палиндромом");
                break;
            }
    }

if (i>0) Console.WriteLine("Число является палиндромом");



