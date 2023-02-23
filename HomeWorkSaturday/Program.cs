using System.Runtime.InteropServices;

namespace HomeWorkSaturday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #21 ------------------------------------------
            //int a = 5;
            //int b = 78;
            //int c = 9;
            //int max = 0;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if(a > b && a>c) 
            //{
            //    max = a;
            //}
            //else if(b>a && b > c)
            //{
            //    max = b;
            //}
            //else
            //{
            //    max = c;
            //}
            //Console.WriteLine($"Max = {max}");

            // #22 ------------------------------------------
            //int a = -1;
            //int b = 3;
            //int c = -6;
            //int min = 0;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if (a < b && a < c)
            //{
            //    min = a;
            //}
            //else if (b < a && b < c)
            //{
            //    min = b;
            //}
            //else
            //{
            //    min = c;
            //}
            //Console.WriteLine($"Min = {min}");

            // #23 ------------------------------------------
            //int a = 5;
            //int b = 78;
            //int c = 1;

            //Console.WriteLine($"numbers : {a}, {b}, {c}");

            //if (a==1 || b==1 || c==1)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // #24 ------------------------------------------
            //int a = 9;
            //int b = 2;
            //int c = 2;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if ((a==2 && b==2 && c!=2) || (a==2 && c==2 && b!= 2) || (b==2 && c==2 && a!=2))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // #25 ------------------------------------------
            //int a = 5;
            //int b = 78;
            //int c = 9;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");

            // #26 ------------------------------------------
            //int a = 23;
            //int b = 27;
            //int c = 24;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");

            //if (a%2==0 || b%2==0 || c % 2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(2);
            //}

            // #27 ------------------------------------------
            //int a = 2;
            //int b = 4;
            //int c = 6;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if (b - a == c - b)
            //{
            //    Console.WriteLine(true);
            //}
            //else { Console.WriteLine(false); }

            // #28 ------------------------------------------
            //int a = 2;
            //int b = 4;
            //int c = 8;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if (b / a == c / b) 
            //{ 
            //    Console.WriteLine(true);
            //}
            //else { Console.WriteLine(false); }

            // #29,#30 ------------------------------------------
            //int a = 9;
            //int b = 7;
            //int c = 5;
            //int max = 0;
            //int min = 0;
            //int middle = 0;
            //Console.WriteLine($"numbers : {a}, {b}, {c}");
            //if ( a>b && a>c) 
            //{
            //    max = a;
            //    if (b < c)
            //    {
            //        min = b;
            //        middle = c;
            //    }
            //    else
            //    {
            //        min = c;
            //        middle = b;
            //    }
            //}
            //else if (b>a && b>c) 
            //{
            //    max = b;
            //    if (a < c)
            //    {
            //        min = a;
            //        middle = c;
            //    }
            //    else
            //    {
            //        min = c;
            //        middle = a;
            //    }
            //}
            //else
            //{
            //    max = c;
            //    if(a < b) 
            //    {
            //        min = a;
            //        middle = b;
            //    }
            //    else
            //    {
            //        min = b;
            //        middle = a;
            //    }
            //}
            //Console.WriteLine($"in ascending order: {min}, {middle}, {max}");
            //Console.WriteLine($"in descending order: {max}, {middle}, {min}");

            // #34 ------------------------------------------
            //int a = 10;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //Console.WriteLine($"numbers : {a}, {b}, {c}, {d}");
            //if (a+b == c+d)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // #52 ------------------------------------------
            //bool even = true;
            //int num = 284;
            //Console.WriteLine(num);
            //while (num > 0)
            //{
            //    int num1 = num % 10;
            //    if (num1 % 2 != 0)
            //    {
            //        even = false;
            //        break;
            //    }
            //    num /= 10;
            //}
            //Console.WriteLine(even);

            //// #54
            //int num = 9123456;
            //int max = 0;
            //Console.WriteLine(num);
            //while(num > 0)
            //{
            //    int num1 = num % 10;
            //    if (num1 > max) 
            //    { 
            //    max = num1;
            //    }
            //    num /= 10;
            //}
            //Console.WriteLine($"max = {max}");

            // #55 ------------------------------------------
            //int num = 9223456;
            //int min = num%10;
            //Console.WriteLine(num);
            //while (num > 0)
            //{
            //    int num1 = num % 10;
            //    if (num1 < min)
            //    {
            //        min = num1;
            //    }
            //    num /= 10;
            //}
            //Console.WriteLine($"min = {min}");

            // #59 ------------------------------------------
            //int num = 567;
            //Console.WriteLine(num);
            //int num1 = num;
            //int max = 0;
            //int min = num % 10;

            //while (num > 0)
            //{
            //    if(num%10 > max) 
            //    {
            //        max = num%10;
            //    }
            //    if (num % 10 < min)
            //    {
            //        min = num % 10;
            //    }

            //    num /= 10;
            //}
            //Console.WriteLine($"min = {min}, max = {max}, middle = {}");
            //while (num1 > 0)
            //{
            //    if (num1 % 10 < min)
            //    {
            //        min = num1 % 10;
            //    }
            //    num1 /= 10;
            //}

            // #151 ------------------------------------------
            //int n = 6;
            //int sum = 0;

            //for (int i = 1; i < n+1; i++)
            //{
            //    if (n%i==0)
            //    {
            //        sum += i;
            //    }

            //}
            //Console.WriteLine(sum);

            // #152 ------------------------------------------
            //int n = 6;
            //int add = 1;

            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        add *= i;
            //    }

            //}
            //Console.WriteLine(add);

            // #153 ------------------------------------------
            //int n = 5;
            //int sum = 0;

            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 2)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            // #154 ------------------------------------------
            //int n = 9;
            //int add = 1;

            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 3)
            //    {
            //        add *= i;
            //    }

            //}
            //Console.WriteLine(add);

            // #155 -----------------------------------------
            //int sum = 0;

            //for (int i = 10; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }

            //}
            //Console.WriteLine(sum);

            // #156 -----------------------------------------
            //long add = 1;

            //for (int i = 10; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i%5==0)
            //    {
            //        add *= i;
            //    }

            //}
            //Console.WriteLine(add);

            // #157 ------------------------------------------
            //int sum = 0;
            //for (int i = 100; i < 1000; i++) 
            //{
            //    if (i%5 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            // #158 ------------------------------------------
            //long add = 1;
            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 2 != 0 && i % 3 != 0)
            //    {
            //        add *= i;
            //    }
            //}
            //Console.WriteLine(add);

            // #159 ------------------------------------------
            //long add = 1;
            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 3 == 1 && i % 4 == 2)
            //    {
            //        add *= i;
            //    }
            //}
            //Console.WriteLine(add);

            // #160 ------------------------------------------
            int min = 0;
            for (int i = 1000; i >= 100; i--)
            {
                for (int j = 1; j < 10000; j++)
                {
                    if (i * 16 == j * j)
                    {
                        min = i;
                        break;
                    }

                }

            }
            Console.WriteLine(min);

            // #161 ------------------------------------------
            //int min = 0;
            //for (int i = 9999; i >= 1000; i--)
            //{
            //    for (int j = 1; j < 10000; j++)
            //    {
            //        if (i * 26 == j * j)
            //        {
            //            min = i;
            //            break;
            //        }

            //    }

            //}
            //Console.WriteLine(min);

            // #165 ------------------------------------------
            //bool t = false;
            //Console.Write("Input n(bnakan): ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 100; i++)
            //{
            //    if (n == Math.Pow(3, i))
            //    {
            //        t = true;
            //        break;
            //    }

            //}
            //Console.WriteLine(t);

            // #166 ------------------------------------------
            //int y = 1;
            ////int num = 4;
            ////Console.WriteLine(Math.Pow(4,0));
            //Console.Write("Input n(bnakan): ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine($"i = {i}, pow = {Math.Pow(4,i)}, n = {n}");
            //    if (n != Math.Pow(4, i))
            //    {
            //        Console.WriteLine("hey you");
            //        y = 0;
            //        //break;
            //    }

            //}
            //Console.WriteLine(y);







        }
    }
}