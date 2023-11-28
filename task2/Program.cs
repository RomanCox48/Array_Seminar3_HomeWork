// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)      //Генерация массива
{
    array[i] = new Random().Next(1, 101);
}
Console.WriteLine(string.Join(", ", array)); //Вывод полученного массива

int count = 0;
for (int i = 0; i < array.Length; i++)      //Подсчёт чётных чисел 
{                                           
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);                   //Вывод результата