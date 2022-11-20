// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay > 0 && numDay < 8)
{
    if (numDay > 5 && numDay < 8)
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Нет");
}
else
    Console.WriteLine("Нет такого дня недели");