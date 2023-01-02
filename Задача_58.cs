// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность массива");
int razmernost=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
// в целях упрощения задачи взяты матрицы одинаковой размерности, благодаря чему не надо проводить проверку на согласованность матриц (число столбцов в матрице_1=числу строк в матрице_2)

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

int [,] MatrixProd(int [,] mat1, int [,] mat2)
{
    int [,] result=new int[razmernost,razmernost];
    for (int i = 0; i<mat1.GetLength(0); i++)
    {
        for (int j = 0; j <mat1.GetLength(1); j++)
        {
            result[i,j]=0;
            for (int k = 0; k <mat1.GetLength(1); k++)
            {
                result[i,j]+=mat1[i,k]*mat2[k,j];
            }
        }
    }
    return result;
}

int [,] matrix1=CreateMatrix();
PrintMatrix(matrix1);
Console.WriteLine();
int [,] matrix2=CreateMatrix();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(MatrixProd(matrix1,matrix2));