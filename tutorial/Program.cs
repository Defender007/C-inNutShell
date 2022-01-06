using System;

namespace tutorial
{
    /*  delegate int RunFunc(int[] lst, int i);
     class Program
     {
         static void Main(string[] args)
         {
             RunFunc r = LocalFunc;
             int[] localArray = { 1, 2, 3, 4, 5, 6, 7 };
             int localIndex = 5;

             Console.WriteLine($"Value at Index Idx => {r(localArray, localIndex)}");
             Console.WriteLine($"LocalArray Size is {localArray.Length}");

             Console.WriteLine("Hello World!");
         }

         static int LocalFunc(int[] arr, int idx)
         {
             return arr[idx];
         }
     } */

    //****Multicast Delegate...
    /* public delegate void ProgressReporter(int percentComplete);
    public class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }
    }

    class Test
    {
        static void Main()
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }
        static void WriteProgressToConsole(int percentComplete)
        => Console.WriteLine(percentComplete);
        static void WriteProgressToFile(int percentComplete)
        => System.IO.File.WriteAllText("progress.txt",
        percentComplete.ToString());
    } */

    //****Generic Delegate...
    public delegate T Transformer<T>(T arg);
    public class Util
    {
        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }
    class Test
    {
        static void Main()
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square); // Hook in Square
            foreach (int i in values)
                Console.WriteLine(i + " "); // 1 4 9
        }
        static int Square(int x) => x * x;
    }
}
