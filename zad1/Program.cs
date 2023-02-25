/*Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void EvenNumbers(int[] array, out int even)
{
    even = 0;
    

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even += 1;
        }
        else
        {
            even += 0;
        }
    }
}

const int SIZE = 5;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
EvenNumbers(myArray, out int even);
System.Console.WriteLine($"количество чётных чисел: {even}");
