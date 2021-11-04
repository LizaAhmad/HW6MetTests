using System;
namespace HW6MetTests
{
    public class HW3
    {
        public HW3()
        {
        }

        #region GetNumPower
        //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        public static double GetNumPower(double a, double b) 
        {
            double p = a;
            if (b == 0)
            {
                p = 1; 
            }
            else if (b > 0)
            {

                for (int i = 0; i < b - 1; i++)
                {
                    p *= a;

                }  
            }
            else
            {
                for (int i = 0; i < b - 1; i++)
                {
                    p *= a;
                }
                p = 1 / p;
                
            }
            return p;
        }
        #endregion

    }
}
