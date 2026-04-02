using System;

namespace Calculator.Core;

public static class Calc
{
    public static double Div(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль запрещено");
        }
        //TODO: Добавить проверку деления
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль запрещено");
        }

        return a / b;
    }
}