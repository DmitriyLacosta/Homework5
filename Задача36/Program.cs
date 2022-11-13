// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Программа, выводит сумму элементов нечётных позиций в массиве ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

int[] array = new int[length];

RandomArray(array);
PrintArray(array);
EvenIndex(array);

// Функция считывания положительного числа из консоли
void ReadLine()                   
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

// Функция вывода суммы нечётных позиций элементов в массиве
void EvenIndex(int[] array)       
{
    int sum = 0;
    for (int i = 1; i < length; i+=2)
    {
        sum = array[i] + sum; 
            
    }
    Console.WriteLine("Сумма нечётных элементов в массиве = " + sum);
}

// Функция заполнения массива в случайном порядке
void RandomArray(int[] array)     
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
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