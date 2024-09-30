using System;

// Перечисление для типов операций
enum OperationType
{
    Addition,       // Сложение
    Subtraction,    // Вычитание
    Multiplication, // Умножение
    Division,       // Деление
    Power,          // Возведение в степень
    SquareRoot      // Вычисление квадратного корня
}

class Program
{
    // Функция для выполнения операции
    static double DoOperation(OperationType op, double a, double b = 0)
    {
        switch (op)
        {
            case OperationType.Addition:
                return a + b;
            case OperationType.Subtraction:
                return a - b;
            case OperationType.Multiplication:
                return a * b;
            case OperationType.Division:
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return 0;
                }
            case OperationType.Power:
                return Math.Pow(a, b);
            case OperationType.SquareRoot:
                if (a >= 0)
                {
                    return Math.Sqrt(a);
                }
                else
                {
                    Console.WriteLine("Ошибка: квадратный корень из отрицательного числа!");
                    return 0;
                }
            default:
                Console.WriteLine("Ошибка: неизвестная операция!");
                return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возведение в степень");
        Console.WriteLine("6. Вычисление квадратного корня");

        int choice = int.Parse(Console.ReadLine());
        OperationType operation = (OperationType)(choice - 1);

        double a, b;

        if (operation == OperationType.SquareRoot)
        {
            Console.WriteLine("Введите число для вычисления квадратного корня:");
            a = double.Parse(Console.ReadLine());
            b = 0;
        }
        else
        {
            Console.WriteLine("Введите первое число:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = double.Parse(Console.ReadLine());
        }

        double result = DoOperation(operation, a, b);
        Console.WriteLine("Результат: " + result);
    }
}