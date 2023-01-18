Console.Clear();
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
double Number(int a, int b)
{
    double result =Math.Pow(a,b);
    return result;
}
Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Number(a , b);
double count = Number(a,b);

Console.WriteLine("Your value: " + count);
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int Sum(int number)
{
    int result = 0;
    while(number > 0)
    {   
        int count = number % 10;
        result=result + count;
        number = number/10;
    }
    return result;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Sum(number);
int sum = Sum(number);
Console.WriteLine("The sum of your digits: " + sum);
/*
/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] CreateArray(int size)
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

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);
ShowArray(newArray);
*/