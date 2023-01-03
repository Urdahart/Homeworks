// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размерность трёхмерного массива");
int razmernost=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,,] CreateMatrix()
{
    int [,,] ret=new int[razmernost,razmernost,razmernost];
    
    for (int i = 0; i < ret.GetLength(0); i++)
    {
        for (int j = 0; j < ret.GetLength(1); j++)
        {
            for(int k = 0; k < ret.GetLength(2); k++)
            {
              ret[i,j,k]= new Random().Next(10,100);
            }        
        }
    }
    return ret;
}

int [,,] CheckMatrix(int [,,] ret)
{
    int [] array=new int[razmernost*razmernost*razmernost];
    int ch=0;
    for (int i = 0; i < ret.GetLength(0); i++)
    {
        for (int j = 0; j < ret.GetLength(1); j++)
        {
            for(int k = 0; k < ret.GetLength(2); k++)
            {
                array[ch]=ret[i,j,k];              
                ch++;
            }        
        }
    }
    
    // генерим новое число, если есть повтор
    int [] array1=array;

    for (int l = 0; l < array.Length; l++)
    {
        for (int m=0; m < array1.Length; m++)
        {
            if ((l!=m)&&(array[l]==array1[m])) 
            {
                array[l]=new Random().Next(10,100);
                l=0;
            }
        }
    }

    // сворачиваем массив в трехмерную матрицу обратно
    int ch1=0;
    for (int i = 0; i < ret.GetLength(0); i++)
    {
        for (int j = 0; j < ret.GetLength(1); j++)
        {
            for(int k = 0; k < ret.GetLength(2); k++)
            {
                ret[i,j,k]=array[ch1];
                ch1++;
            }
        }
    }
    return ret;
}


void PrintMatrix(int [,,] print_ret)
{
   for (int i = 0; i<print_ret.GetLength(0); i++)
    {
        for (int j = 0; j <print_ret.GetLength(1); j++)
        {
            for(int k = 0; k<print_ret.GetLength(2); k++)
            {
              Console.Write($"{print_ret[i,j,k]}({i},{j},{k}) ");
            } 
        Console.WriteLine();        
        }
    }
}


int [,,] matrix1=CreateMatrix();
//PrintMatrix(matrix1); //печать первоначальной матрицы, для дебага и костыля
//Console.WriteLine();
PrintMatrix(CheckMatrix(matrix1));