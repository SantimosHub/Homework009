// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int AllNumbersSum(int inFirstNumber, int inSecondNumber)
{
    if (inFirstNumber == inSecondNumber) return inSecondNumber;
    return inFirstNumber + AllNumbersSum(inFirstNumber + 1, inSecondNumber);
}

int firstNumber = new Random().Next(0, 20);
int secondNumber = new Random().Next(0, 20);
if (firstNumber > secondNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}

Console.WriteLine($"Сумма чисел между {firstNumber} и {secondNumber} = {AllNumbersSum(firstNumber, secondNumber)} ");