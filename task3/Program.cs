// Задайте массив из вещественных чисел с 
// ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
double[] array = new double[x];                 //Генерация массива из дробных чисел с двумя знаками после запятой
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100) + Math.Round(new Random().NextDouble(),2);
Console.WriteLine(string.Join(", ", array));
                                                //Вывод полученного массива
double max = array [0];
double min = array [0];

for (int i = 0; i < array.Length; i++)          //Поиск максимума и минимума
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Максимум: " + max + " Минимум: " + min);
Console.WriteLine("Разница: " + (max - min));                   //Вывод разницы между максимумом и минимумом