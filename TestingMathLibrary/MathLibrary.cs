using System;
using System.Collections.Generic;

namespace TestingMathLibrary
{
    public class MathLibrary : Interface1
    {

            public int Add(int i, int j)
            {
                return i + j;
            }
            public int Subtract(int i, int j)
            {
                return i - j;
            }
            public int Multiply(int i, int j)
            {
                return i * j;
            }

            public int Divide(int i, int j)
            {
                return i / j;
            }
            public int Power(int i, int j)
            {
                var answer = 1;
                for (var idx = 0; idx < j; idx++)
                    answer *= i;
                return i;
            }

            public int Square(int i, int j)
            {

                return i ^ 2;
            }

            public int Factorial(int i, int j)
            {
                int res = 1;
                while (i != 1)
                {
                    res = res * i;
                    i = i - 1;
                }
                return i;
            }

            public int Modulo(int i, int j)
            {
                return i - (i / j * j);
            }


        


    }
}
