Console.Clear();
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size,int minValue,int maxValue)
{       
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumOfEvenNumbers(int[] newArray,int count = 0)
{
     for(int i=0; i < newArray.Length; i++)
     {
        int cent = newArray[i]%2;
            if (cent == 0)
                {
                count = count + 1;
                }
            else
            {
                count= count + 0;
            }
     }
return count;
}



Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int minValue = 100;
int maxValue = 999;

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ShowArray(newArray);

SumOfEvenNumbers(newArray);
int result = SumOfEvenNumbers(newArray);
Console.WriteLine("\nSum of even numbers: " + result);
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int size,int minValue,int maxValue)
{       
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumOfNumbers(int[] newArray,int count = 0)
{
     for(int i=0; i < newArray.Length; i++)
     {
        int cent = i%2;
            if (cent == 0)
                {
                count=count + 0;
                }
            else
            {
                count= count + newArray[i];
            }
     }
return count;
}



Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int minValue = -100;
int maxValue = 100;

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ShowArray(newArray);

SumOfNumbers(newArray);
int result = SumOfNumbers(newArray);
Console.WriteLine("\nSum of numbers: " + result);
*/
/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] CreateRandomArray(int size)
{       
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int Numbers(int[] newArray, int min = 0, int max =0)
{
    max = newArray[0];
    min = newArray[0];
     for(int i=1; i < newArray.Length; i++)
     {
        if(newArray[i] > max)
        {
            max = newArray[i];
        }
        if(newArray[i] < min)
        {
            min = newArray[i];
        }
     }
int count = max - min;
return count;
}



Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length);
ShowArray(newArray);

Numbers(newArray);
int result = Numbers(newArray);
Console.WriteLine("\nThe difference between the maximum and minimum value: " + result);