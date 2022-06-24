/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
chekEvenNumber(number); //вызов метода
//chekEvenNumber(54);
//chekEvenNumber(53);
void chekEvenNumber(int currentNumber)
{
    if (currentNumber % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else 
    {
        Console.WriteLine("Число является нечетным");
    }
}
//сделал через метод, но в данной ситуации он, как я понимаю, совсем не нужен