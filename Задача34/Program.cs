// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Программа, показывает кол-во чётных чисел в сгенерированном массиве ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

int[] array = new int[length];

RandomArray(array);
PrintArray(array);
EvenNumbers(array);

// Функция считывания положительного числа из консоли
void ReadLine()                   
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

// Функция вывода кол-ва чётных чисел в массиве
void EvenNumbers(int[] array)     
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Кол-во чётных чисел в массиве = " + count);
}

// Функция заполнения массива в случайном порядке
void RandomArray(int[] array)     
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

// Функция вывода массива в консоль
void PrintArray(int[] array)      
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}