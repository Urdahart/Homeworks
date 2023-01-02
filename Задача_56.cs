// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размерность массива");
int razmernost=Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int [,] CreateMatrix()
{
    int [,] ret=new int[razmernost,razmernost];
    for (int i = 0; i<ret.GetLength(0); i++)
    {
        for (int j = 0; j <ret.GetLength(1); j++)
        {
            ret[i,j]= new Random().Next(10);
        }
    }
    return ret;
}

void PrintMatrix(int [,] print_ret)
{
   for (int i = 0; i<print_ret.GetLength(0); i++)
    {
        for (int j = 0; j <print_ret.GetLength(1); j++)
        {
            Console.Write(print_ret[i,j]+" "); 
        }
    Console.WriteLine();
    }
}

void MinSumOfRow(int [,] matrix)
{
    int [] sum= new int[razmernost];
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            sum[i]+=matrix[i,j];
        }
    }
    int min=sum[0];
    int flag=0;
    for(int k=0; k<sum.Length;k++)
    {
        if (sum[k]<min) 
        {
            min=sum[k];
            flag=k;
        }
    }
    Console.WriteLine($"{flag+1} строка с наименьшей суммой элементов");
}

int [,] matrix=CreateMatrix();
PrintMatrix(matrix);
Console.WriteLine();
MinSumOfRow(matrix);
