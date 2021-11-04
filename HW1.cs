using System;
namespace HW6MetTests
{
    public class HW1
    {
        public HW1()
        {
        }

        #region GetResultFormula
        // Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5 * a + b * b)/(b - a)
        public static double GetResultFormula(double a, double b)
        {
            double result = (5 * a + b * b) / (b - a);

            if (a == b)
            {
                throw new DivideByZeroException("на нуль делить нельзя");
            }

            return result;
        }
        #endregion

        #region SwapStrings
        //Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.
        public static void SwapStrings(ref string a, ref string b) 

        {
            string tmp = a;
            a = b;
            b = tmp;
        }
        #endregion

        #region GetQuotientAndRemainder
        //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B
        public static int GetQuotient(int a, int b)

        {
            int q = a / b;
            if (b == 0)
            {
                throw new DivideByZeroException("на нуль делить нельзя");
            }
            return q;
        }

        public static int GetRemainder(int a, int b)  
        {
            if (b == 0)
            {
                throw new DivideByZeroException("на нуль делить нельзя");
            }
            int r = a % b;
            return r;
        }
        #endregion

        #region GetResultOfEquation
        //Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static double GetResultOfEquation(double a, double b, double c) 

        {

            double x = (c - b) / a;

            if(a == 0)
            {
                throw new DivideByZeroException("на нуль делить нельзя");
            }
            return x;
        }
        #endregion

        #region GetEquationStraight
        //Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.
        public static string GetEquationStraight(double x1, double y1, double x2, double y2)
        {
            double a = (y1 - y2) / (x2 - x1);
            double b = (x1 * y2 - x2 * y1) / (x2 - x1);
            return $"y = {a} * x + {b}";
        }
        #endregion
    }

}