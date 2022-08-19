// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран. 
// Вводим массив через консоль
int[] arr = new int[8];
Console.WriteLine("Введите восемь чисел");
for (int i=1; i<arr.Length; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
//Console.WriteLine("CREATED");
Console.Write(string.Join(", ", arr));