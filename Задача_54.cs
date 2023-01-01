// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите количество строк");
int row=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colums=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] CreateMatrix()
{
    int [,] ret=new int[row,colums];
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

int [,] OrderRows(int [,] matr)
{
    
    for (int i = 0; i<matr.GetLength(0); i++)
        {
            for (int j = 0; j <matr.GetLength(1); j++)
            {
                int temp=0;
                for (int k=0; k<matr.GetLength(1)-1;k++)
                {
                    if (matr[i,k]<matr[i,k+1])
                    {
                        temp=matr[i,k];
                        matr[i,k]=matr[i,k+1];
                        matr[i,k+1]=temp;
                    }
                }
            }
            
        }
    return matr;
}

int [,] matrix=CreateMatrix();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(OrderRows(matrix));
