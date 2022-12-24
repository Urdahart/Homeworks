/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void ArrayInOutput()
{
    int [] a = new int[8];
    for (int i=0; i<a.Length; i++)
        {
           Console.WriteLine("Введите элемент массива"); 
           a[i]=Convert.ToInt32(Console.ReadLine());
        }
    for (int j=0; j<a.Length; j++)
        {
            if(j==a.Length-1) Console.WriteLine(a[j]);
            else Console.Write(a[j]+", ");
        }
}  

ArrayInOutput();