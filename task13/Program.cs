//  Напишите программу, которая выводит третью цифру заданного числа 
//  или сообщает, что третьей цифры нет.

//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6


int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine(number % 10);
}
else if (number < 99)
{
    Console.WriteLine("Нет третьего числа");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}