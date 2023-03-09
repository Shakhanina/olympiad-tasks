using System;

namespace паук_и_муха
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            int r = 0;
            int r1 = 0;
            int a = 60;
            int b = 60;
            int c = 60;
            int[] S = new int[3] { 40, 0, 10 };
            int[] F = new int[3] { 50, 60, 40 };
            if ((S[1] == 0 && F[1] == 0))//2* y = 0  и z = c
            {
                if (c == S[2] && c == F[2])
                {
                    result = Math.Abs(S[0] - F[0]);
                    Console.WriteLine(Math.Round(result, 3));
                }
                else
                {
                    r = a - S[0];
                    result = Math.Sqrt(r * r + F[2] * F[2]);
                    Console.WriteLine(Math.Round(result, 3));
                }
            }
            else if (S[0] == 0 && F[0] == 0) // x1 = x2 = 0
            {
                r = Math.Abs(S[2] - F[2]);
                r1 = Math.Abs(S[1] - F[1]);
                result = Math.Sqrt(r * r + r1 * r1);
                Console.WriteLine(Math.Round(result, 3));


            }
            else if ((S[0] == F[0]) && (S[1] == F[1])) // x1 = x2 and y1 = y2 (and z1=z2) 
            {
                if (S[2] == F[2])
                {
                    result = 0;
                    Console.WriteLine(Math.Round(result, 3));
                }
                else
                {
                    result = Math.Abs(S[2] - F[2]);
                    Console.WriteLine(Math.Round(result, 3));
                }

            }
            else if (S[1] == 0 && F[0] == a)
            {
                if (S[2] == c && F[1] == b)
                {
                    r = a + b;
                    r1 = c;
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }
                else
                {
                    r = a - S[0];
                    r1 = b - F[1];
                    result = r + r1;
                    Console.WriteLine(Math.Round(result, 3));
                }

            }
            else if (F[2] == c)
            {
                if (S[0] == a)
                {
                    r = c - S[2];
                    r1 = a - F[0];
                    result = r + r1;
                    Console.WriteLine(Math.Round(result, 3));
                }
                else if (S[1] == 0)
                {
                    r = S[0] - F[0];
                    r1 = F[1] + (c - S[2]);
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }

            }
            else if (F[1] == b)
            {
                if (S[0] == 0)
                {
                    r = S[2] - F[2];
                    r1 = (b - S[1]) + F[0];
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }
                else if (S[0] == a)
                {
                    r = S[2] - F[2];
                    r1 = (b - S[1]) + (a - F[0]);
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }
                else if (S[1] == 0)
                {
                    r = Math.Abs(S[0] - F[0]); 
                    r1 = b + S[2] + F[2];
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }
            }
            else if (S[1] == b && F[2] == 0)
            {
                r = S[2] + (S[1] - F[1]);
                r1 = S[0] - F[0];
                result = Math.Sqrt(r * r + r1 * r1);
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (S[0] == a)
            {
                if (F[1] == 0)
                {
                    r = S[2] - F[2];
                    r1 = S[1] + a - F[0];
                    result = Math.Sqrt(r * r + r1 * r1);
                    Console.WriteLine(Math.Round(result, 3));
                }
            }
            else if (S[0] == 0 && F[1] == 0)
            {
                r = S[2] - F[2];
                r1 = S[1] + F[0];
                result = Math.Sqrt(r * r + r1 * r1);
                Console.WriteLine(Math.Round(result, 3));
            }

            else if (S[0] == 0)
            {
                r = S[2] + F[0];
                r1 = S[1] - F[1];
                result = Math.Sqrt(r * r + r1 * r1);
                Console.WriteLine(Math.Round(result, 3));
            }

            else
            {
                r = S[1] + F[0];
                r1 = S[2] - F[2];
                result = Math.Sqrt(r * r + r1 * r1);
                Console.WriteLine(Math.Round(result, 3));
            }
        }
    }
}
