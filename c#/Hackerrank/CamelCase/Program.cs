using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static long Caculate(int n)
    {
        long sum = 0;
        long highestPower3 = (n - 1) / 3;
        long highestPower5 = (n - 1) / 5;
        long highestPower15 = (n - 1) / 15;

        sum = ((highestPower3 * (2 * 3 + (highestPower3 - 1) * 3)) +
               (highestPower5 * (2 * 5 + (highestPower5 - 1) * 5)) -
               (highestPower15 * (2 * 15 + (highestPower15 - 1) * 15))) / 2;

        return sum;
    }
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        long[] sumOfGCD = new long[t];   
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());     
            sumOfGCD[a0] = Caculate(n);
        }
        for (int i = 0; i < sumOfGCD.Length; i++)
        {
            Console.WriteLine(sumOfGCD[i]);
        }
    }
}