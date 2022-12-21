//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет 
//32679 -> 6
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int num1=a/100;
int num2=num1%10;

if (a>99)
    {
        if (num1>100)
            {
              Console.WriteLine(num2);  //только для случая 5-ти значного числа
            }
        else
            {
                Console.WriteLine(a%10);
            }
    }
else
    {
        Console.WriteLine("Третьей цифры нет");
    }
