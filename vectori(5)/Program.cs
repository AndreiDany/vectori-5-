using System;

namespace vectori_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int n;
            int[] frequencies = new int[100];
            n = Int32.Parse(Console.ReadLine());
            int maxx = int.MinValue;
            int minn = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
                frequencies[v[i]]++;
                if (v[i] > maxx) maxx = v[i];
                if (v[i] < minn) minn = v[i];
            }
            for (int i = minn; i <= maxx; i++)
            {
                Console.WriteLine(frequencies[i]);
            }
        }
    }
}
