// Задайте значения M и N. Найти сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

int GetNumberByUser()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumMN(int numberM, int numberN)
{
    if (numberN == numberM) return numberM;
    else return numberN + SumMN(numberM, numberN - 1);
}

int number1 = GetNumberByUser();
int number2 = GetNumberByUser();
Console.WriteLine($"Сумма элементов от {number1} до {number2} = {SumMN(number1, number2)}");



