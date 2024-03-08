using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkipListLib;
using System.Diagnostics;

namespace RealizeSkipList
{
    internal class Program
    {
        public static void Shuffle(int[] arr)
        {
            Random rand = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        static void Main(string[] args)
        {
            int[] digits = new int[10000];
            for (int i = 0; i < 10000; i++)
                digits[i] = i;
            Shuffle(digits);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            SkipList<int, int> skiplist = new SkipList<int, int>();
            for (int i = 0; i < 10000; i++)
                skiplist.Add(digits[i], 1);
            for (int i = 5000; i < 7000; i++)
                skiplist.Remove(digits[i]);
            for (int i = 0; i < 10000; i++)
                skiplist.Contains(digits[i]);
            stopwatch.Stop();
            Console.WriteLine($"Время SkipList: {stopwatch.ElapsedMilliseconds} мс");

            stopwatch.Restart();
            SortedList<int, int> sortList = new SortedList<int, int>();
            for (int i = 0; i < 10000; i++)
                sortList.Add(digits[i], 1);
            for (int i = 5000; i < 7000; i++)
                sortList.Remove(digits[i]);
            for (int i = 0; i < 10000; i++)
                sortList.ContainsKey(digits[i]);
            stopwatch.Stop();
            Console.WriteLine($"Время SortedList: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}
