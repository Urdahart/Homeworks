/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] arr = new int[4];
int sum=0;

for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,1000);
        if(i==arr.Length-1) Console.WriteLine(arr[i]);
        else Console.Write(arr[i]+", ");
        if ((i%2)!=0) sum+=arr[i];
    }

Console.WriteLine(sum);