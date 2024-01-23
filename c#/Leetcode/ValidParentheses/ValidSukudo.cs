using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class ValidSukudo
    {
        public static bool IsValidSukudo(char[][] sudoku)
        {
            GC.Collect();
            HashSet<char> rowSet = new HashSet<char>();
            HashSet<char> colSet = new HashSet<char>();
            Dictionary<(int, int), HashSet<char>> squareSet = new Dictionary<(int, int), HashSet<char>>();
            for (int i = 0; i < 9; i++)
            {
                 rowSet = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == '.')
                        continue;

                    if (!rowSet.Add(sudoku[i][j]))
                        return false; // Duplicate in the row
                }
            }

            // Check each column
            for (int j = 0; j < 9; j++)
            {
                colSet = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (sudoku[i][j] == '.')
                        continue;

                    if (!colSet.Add(sudoku[i][j]))
                        return false; // Duplicate in the column
                }
            }

            // Check each 3x3 square
           for(int i = 0; i< 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                   
                    if (sudoku[i][j] == '.')
                    {
                        continue;
                    }
                    if (!squareSet.ContainsKey((i / 3, j / 3)))
                    { 
                        squareSet.Add((i / 3, j / 3), new HashSet<char>()); 
                    }
                    if (!squareSet[(i / 3, j / 3)].Add(sudoku[i][j]))
                    {
                        return false;
                    }
                           
                }
            }

            return true;

        }
    }
}
