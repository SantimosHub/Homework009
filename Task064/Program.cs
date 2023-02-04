// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string AllNaturalNumbers(int inNumber)
{
    if (inNumber == 0) return String.Empty;
    return $"{inNumber} " + AllNaturalNumbers(inNumber - 1);
}

int number = new Random().Next(0, 20);
Console.WriteLine($"{number} -> {AllNaturalNumbers(number)} ");