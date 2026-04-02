using System;

namespace Calculator.Core;

/// <summary>
/// Класс для вычислений.
/// </summary>
public static class Calc
{
    /// <summary>
    /// Вычисляет деление двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второй число.</param>
    /// <returns>Результат деления.</returns>
    /// <exception cref="DivideByZeroException">Если второе число равно 0.</exception>
    public static double Div(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль запрещено");
        }

        return a / b;
    }
}