using System;
namespace HW6MetTests
{
    public class HW2
    {
        public HW2()
        {
        }
        #region GetNumbers
        //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static double GetNumbers(double a, double b)
        {
            double result = 0;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            
            return result;
        }
        #endregion

        #region FindQuarter
        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y).

        public static int FindQuarter(double x, double y)
        {
            int quarter = 0;
            if (x > 0 && y > 0)
            {
                quarter = 1;
            }
            else if (x > 0 && y < 0)
            {
                quarter = 2;
            }
            else if(x < 0 && y < 0)
            {
                quarter = 3;
            }
            else if(x < 0 && y > 0)
            {
                quarter = 4;
            }
            
            if (x == 0 || y == 0)
            {
                throw new Exception("impossible find quarter");
            }
            
            return quarter;
        }
        #endregion

        #region GetHighingOrder
        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

        public static int[] GetHighingOrder(int a, int b, int c)
        {
            int[] order = new int[3];
            if (a < b)
            {
                if (b < c)
                {
                    order = new int[] { a, b, c };
                }
                else
                {
                    order = new int[] { a, c, b };
                }
            }
            if (c < a)
            {
                if (a < b)
                {
                    order = new int[] { c, a, b };
                }
                else
                {
                    order = new int[] { c, b, a };
                }
            }
            if (b < a)
            {
                if (a < c)
                {
                    order = new int[] { b, a, c };
                }

                else
                {
                    order = new int[] { b, c, a };
                }
            }
            return order;
        }
        #endregion

        #region SolveQuadraticEquation
        //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double dskr = b * b - 4 * a * c;
            double x = 0;
            double x1 = 0;
            double x2 = 0;
            if (dskr == 0)
            {
                x = ((-b) / 2 * a);
                double[] result = new double[1];
                result = new double[] { x };
                return result;
            }
            if (dskr > 0)
            {
                x1 = ((-b) + Math.Sqrt(dskr)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(dskr)) / (2 * a);
                double[] result = new double[2];
                result = new double[] { x1, x2 };
                return result;
            }
            else
            {
                double[] result = new double[1];
                result = new double[] { 0 };
                return result;
            }
        }
        #endregion
    }
}
