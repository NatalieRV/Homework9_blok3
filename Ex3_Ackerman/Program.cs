// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

double GetNumberByUser()
{
    Console.Write("Введите значение переменной: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Ackerman(double number1, double number2)
{
    if (number1 == 0) return number2 + 1;
    else if (number1 > 0 && number2 == 0) return Ackerman(number1 - 1, 1);
    else return Ackerman(number1 - 1, Ackerman(number1, number2 - 1));
}

double num1 = GetNumberByUser();
double num2 = GetNumberByUser();
Console.WriteLine();
Console.WriteLine($"Функция Аккермана = {Ackerman(num1, num2)}");

