// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 912 -> 12

Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int res = 0;
for (int num2=1; num1>0; num2++);
{
    res=res+num1%10;
    num1=num1/10;
}
Console.WriteLine($"Сумма цифр в числе равна {res}");