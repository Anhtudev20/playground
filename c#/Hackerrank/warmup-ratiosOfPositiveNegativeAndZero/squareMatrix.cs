using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warmup_ratiosOfPositiveNegativeAndZero
{
     class squareMatrix
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRightDiagonalSum = 0;
            int rightToLeftDiagonalSum = 0;
             int count = 0;
            for (int i = 0; i < arr.Count(); i++)
            {         
                count = arr[i].Count() - 1;
                leftToRightDiagonalSum += arr[i][i];
                rightToLeftDiagonalSum += arr[i][count - i];                   
            }
            int diagonalDifferentNumber = Math.Abs(leftToRightDiagonalSum - rightToLeftDiagonalSum);
            return diagonalDifferentNumber;
        }
        public static void solution() {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);

          
        }
    }
    }

