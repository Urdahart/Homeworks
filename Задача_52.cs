// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int row=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colums=Convert.ToInt32(Console.ReadLine());
int [,] matrix=new int[row,colums];
double[] array= new double[colums];
 Console.WriteLine();

void CreateMatrix(int [,] matr)
{
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(10);
            Console.Write(matr[i,j]+" ");
        }
    Console.WriteLine();
    }
}
CreateMatrix(matrix);

for (int j = 0; j<colums; j++)
    {
        for (int i = 0; i <matrix.GetLength(0); i++)
        { 
            array[j]+=Convert.ToDouble(matrix[i,j]);
        }
        array[j]/=matrix.GetLength(0);
        Console.WriteLine("________________________________________");
        Console.WriteLine(Math.Round(array[j],2));
    }


