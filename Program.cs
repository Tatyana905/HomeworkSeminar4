// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.Write("Ввведите число - ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите степень - ");
int pow = Convert.ToInt32(Console.ReadLine());

int i = 1;
double result = 1;
while (i <= pow)
{
    result = result * num;
    i++;
}
Console.WriteLine($"Число {num} в степени {pow} - это {result}");
*/


// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.Write("Ввведите число - ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
Console.WriteLine(result);
*/


 // 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] GetArray (int size) 
{
    int[] result = new int[size]; 
    for (int i = 0; i < result.Length; i++) 
    {
        Console.Write("Введите элемент -  ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

int[] array = GetArray(8);

Console.WriteLine($"Результат: [ {String.Join(";", array)}]"); 
