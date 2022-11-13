//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Программа, которая находит разницу между максимальным и минимальным элементом массива ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

double[] array = new double[length];

RandomArray(array);
PrintArray(array);
MaxMinDif(array);

// Функция считывания положительного числа из консоли
void ReadLine()                      
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

// Функция заполнения массива в случайном порядке вещественными числами
void RandomArray(double[] array)     
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив ");
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 2);
    }
}

// Функция вывода массива в консоль
void PrintArray(double[] array)      
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Функция вывода разницы максимального и минимального элемента массива
void MaxMinDif(double[] array)       
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference);
}