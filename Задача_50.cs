// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int [,] matrix=new int[3,4];

for (int i = 0; i< matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(10);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию элемента в двумерном массиве, 2 целых числа");
int pos1=Convert.ToInt32(Console.ReadLine());
int pos2=Convert.ToInt32(Console.ReadLine());

if (pos1>matrix.GetLength(0) || pos2>matrix.GetLength(1)) Console.WriteLine("Такого элемента не существует");
else 
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (matrix[i,j]== matrix[pos1,pos2])  Console.WriteLine("Такой элемент существует, он равен "+ matrix[i,j]);        
        }
    }
}

