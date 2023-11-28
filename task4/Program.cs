// Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива,
// младший – на последнем. 
// Размер массива должен быть равен количеству цифр.


int number = new Random().Next(1, 100001);  //Получаем число в диапазоне от 1 до 100 000.
Console.WriteLine(number);
int reversedNumber = 0;                     //Вводим переменную для помещения в нее инвертированного числа
int digitCount = 0;                         //Вводим переменную для подсчёта количества цифр
while (number > 0)                          //Процесс инвертирования и подсчёта количества цифр
{
    int digit = number % 10;
    reversedNumber = reversedNumber * 10 + digit;
    number /= 10;
    digitCount++;
}
int [] array = new int [digitCount];        //Определяем массив с заданным количеством значений
 while (digitCount > 0)                     //Процесс записи цифр инвертированного числа в массив
 {
   for (int i = 0; i<array.Length; i++)
   {
    int digit = reversedNumber % 10;
    array[i] = digit;
    reversedNumber /= 10;
    digitCount--;
    }
 }

Console.WriteLine(string.Join(", ", array));    //Вывод результата