/* 

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber) 
{
 Console.WriteLine($"Максимальное число: {firstNumber}, минимальное число: {secondNumber}");
}
else if (firstNumber < secondNumber)
{ 
 Console.WriteLine($"Максимальное число: {secondNumber}, минимальное число: {firstNumber}");
}
else if (firstNumber == secondNumber )
{
Console.WriteLine("Максимального значения нет, числа равны");
}
else
{ 
 Console.WriteLine("Введите другие числа");
}
