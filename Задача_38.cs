/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[n];

for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,1000);
        if(i==arr.Length-1) Console.WriteLine(arr[i]);
        else Console.Write(arr[i]+", ");
    }

Console.WriteLine(arr.Max()-arr.Min());
