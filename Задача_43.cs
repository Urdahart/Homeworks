/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Console.WriteLine("Введите k1");
// int k1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2");
// int k2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1");
// int b1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2");
// int b2= Convert.ToInt32(Console.ReadLine());


// double x =(double)(b2-b1)/(double)(k1-k2);

// double y=k1*x+b1;
// Console.WriteLine(y);
// Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");



Console.WriteLine("Введите k1");
double k1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2= Convert.ToDouble(Console.ReadLine());

double x =(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");