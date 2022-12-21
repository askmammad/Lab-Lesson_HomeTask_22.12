namespace Lab_Lesson_HomeTask_22._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Eded sadedir ya yox
            //int a;
            //Console.Write("Ededi daxil edin:");
            //a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 0 || a % 3 == 0)
            //{
            //    Console.Write("Sade eded deyil");
            //}
            //else if (a == 5 && a % 5 == 0 || a == 7 && a % 7 == 0)
            //{
            //    Console.Write("Sade ededdir");
            //}
            //else
            //{
            //    Console.Write("Sade ededdir");
            //}
            #endregion
            #region Eded palindrondu ya yox
            //int n, result = 0;
            //Console.Write("Ededi daxil edin: ");
            //n = Int32.Parse(Console.ReadLine());
            //int a = n;
            //while (a > 0)
            //{
            //    result = result * 10;
            //    result = result + (a % 10);
            //    a = a / 10;
            //}
            //if (result == n)
            //{
            //    Console.WriteLine("Polidron");
            //}
            //else
            //    Console.WriteLine("Polidron deyil");
            #endregion
            #region Eded Fibonaccidir ya yox
            //int n;
            //Console.Write("Uzunlugu daxil edin:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int a;
            //Console.Write("Ededi daxil edin:");
            //a = Convert.ToInt32(Console.ReadLine());
            //int[] Fib = new int[n];
            //Fib[0] = 0;
            //Fib[1] = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    Fib[i] = Fib[i - 1] + Fib[i - 2];
            //    if (a == Fib[i])
            //    {
            //        Console.WriteLine("Fibonacii");
            //    }
            //}
            #endregion
            #region N ededine qeder Fibonacci ededleri
            //int n;
            //Console.Write("Uzunlugu daxil edin:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] Fib = new int[n];
            //Fib[0] = 0;
            //Fib[1] = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    Fib[i] = Fib[i - 1] + Fib[i - 2];
            //    if (Fib[i] <= n)
            //    {
            //        Console.WriteLine(Fib[i]);
            //    }
            //}
            #endregion
            #region N ededine qeder sade ededler
            //int a;
            //Console.Write("Ededi daxil edin:");
            //a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= a; i++)
            //{
            //    if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if ((i == 1) || (i == 2) || (i == 3) || (i == 5) || (i == 7))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Daxil edilen ededlerin ortalamasi
            //int a;
            //int b;
            //int sum = 0;
            //Console.Write("Ededlerin sayi:");
            //a = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write($"arr[{i}]=");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum = sum + arr[i];
            //}
            //b = sum / a;
            //Console.Write("Ortalama:" +b);
            #endregion
            #region Iki eded daxil edilir biri musbet biri menfidirse: true
            //int a;
            //Console.Write("Eded 1:");
            //a = Convert.ToInt32(Console.ReadLine());
            //int b;
            //Console.Write("Eded 2:");
            //b = Convert.ToInt32(Console.ReadLine());
            //if ((a > 0 && b < 0) || (a < 0 && b > 0))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion
            #region Iki ededin cemini tapan proqram. Ededlerden biri 20den boyuk ve ya cem 20 ise: true
            //int a;
            //Console.Write("Birinci eded:");
            //a = Convert.ToInt32(Console.ReadLine());
            //int b;
            //Console.Write("Ikinci eded:");
            //b = Convert.ToInt32(Console.ReadLine());
            //int sum, c;
            //sum = a + b;
            //c = sum;
            //Console.WriteLine("Cem beraberdir:" + c);
            //if ((a > 20) || (b > 20) || (c == 20))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            #endregion
            #region Iki eyni olchulu massivin uygun indeksli elementlerinin hasili
            //int a;
            //Console.Write("Massiv 1:");
            //a = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write($"arr[{i}]=");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int b;
            //Console.Write("Massiv 2:");
            //b = Convert.ToInt32(Console.ReadLine());
            //int[] arr2 = new int[b];
            //int mltp;
            //for (int j = 0; j < b; j++)
            //{
            //    Console.Write($"arr[{j}]=");
            //    arr2[j] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        if (i == j)
            //        {
            //            mltp = arr[i] * arr2[j];
            //            Console.WriteLine("Hasil= " + mltp);
            //        }
            //    }
            //}
            #endregion
        }
    }
}