// Задача 26: Напишите программу, 
// которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int count;
for (count=0; number>0; count++)
{
    number/=10;
}
Console.WriteLine(count);