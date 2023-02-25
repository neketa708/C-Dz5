/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

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

void Element(int[] array, out int max, out int min)
{
    max = 0;
    min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
       if (max < array[i])
       {
        max = array[i];
       } else if (min > array[i])
       {
        min = array[i];
       }
    }
    
}

const int SIZE = 6;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
Element(myArray, out int max, out int min);
System.Console.WriteLine($"разницу между максимальным {max} и минимальным {min} элементов массива: {max-min}");