// Задайте значение N. Вывести все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int GetNumberByUser()
{
    Console.Write("Введите натуральное число N: ");
    return Convert.ToInt32(Console.ReadLine());
}

string NumbersLine(int number)
{
    if (number >= 1) return $"{number} " + NumbersLine(number - 1);
    else return string.Empty;
}

int num = GetNumberByUser();
Console.WriteLine(NumbersLine(num));