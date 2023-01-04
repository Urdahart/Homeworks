// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите М");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());

if(m>n) Console.WriteLine("Числа введены некорректно, M не может быть меньше N");
else
    {
        //создаем метод
        int MethodSum(int start, int end)
        {
            if (start==end) return end;
            return (start+MethodSum(start+1,end));
        }
        Console.WriteLine("Сумма элементов равна "+MethodSum(m,n));
    }
