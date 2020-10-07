using System;
using System.Collections.Generic;

namespace Daily_Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
            foreach (int res in result)
                Console.WriteLine(res);
        }

        static int[] DailyTemperatures(int[] T)
        {
            int[] result = new int[T.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Count > 0 && T[i] > T[stack.Peek()])
                {
                    int idx = stack.Pop();
                    result[idx] = i - idx;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
