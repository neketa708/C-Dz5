/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

void SumElement(int[] array, out int sum)
{
    sum = 0;
    

    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    
}

const int SIZE = 6;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
SumElement(myArray, out int sum);
System.Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {sum}");
