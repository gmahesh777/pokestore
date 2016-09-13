using System;

namespace Pokemon
{
    public class CalculateCost
    {
        public static float Calculate(int A, int B, int C)
        {
            float cost = 0;
            while (A > 0 || B > 0 || C > 0)
            {
                if (A * B * C > 0)
                {
                    cost += 16 * (float)0.8;
                    A--; B--; C--;
                }

                if ((A * B) > 0 && C == 0)
                {
                    cost += 11 * (float)0.9;
                    A--; B--;
                }

                if ((A * C) > 0 && B == 0)
                {
                    cost += 11 * (float)0.9;
                    A--; C--;
                }

                if ((B * C) > 0 && A == 0)
                {
                    cost += 11 * (float)0.9;
                    B--; C--;
                }

                if (A > 0 && B == 0 && C == 0)
                {
                    cost += 6;
                    A--;
                }

                if (B > 0 && A == 0 && C == 0)
                {
                    cost += 5;
                    B--;
                }

                if (C > 0 && A == 0 && B == 0)
                {
                    cost += 5;
                    C--;
                }

            }

            return cost;

        }
    }
}
