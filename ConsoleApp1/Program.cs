using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            const int rowLength = 15;
            int[] array = new int[rowLength];
            int[][] values = new int[rowLength][];

            values[0] = new int[1] { 215 };
            values[1] = new int[2] { 192, 124 };
            values[2] = new int[3] { 117, 269, 442 };
            values[3] = new int[4] { 218, 836, 347, 235 };
            values[4] = new int[5] { 320, 805, 522, 417, 345 };
            values[5] = new int[6] { 229, 601, 728, 835, 133, 124 };
            values[6] = new int[7] { 248, 202, 277, 433, 207, 263, 257 };
            values[7] = new int[8] { 359, 464, 504, 528, 516, 716, 871, 182 };
            values[8] = new int[9] { 461, 441, 426, 656, 863, 560, 380, 171, 923 };
            values[9] = new int[10] { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 };
            values[10] = new int[11] { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 };
            values[11] = new int[12] { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 };
            values[12] = new int[13] { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 };
            values[13] = new int[14] { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 };
            values[14] = new int[15] { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 };

            array[0] = values[0][0];

            bool found = false;
            int j = 0;

            for (int i = 1; i < values.Length; i++) {
                found = false;
                while (found != true)
                {
                    if(array[i-1] % 2 == 0)
                    {
                        if ((values[i][j] % 2 != 0) && (values[i][j+1] % 2 != 0))
                        {
                            array[i] = (values[i][j] > values[i][j + 1]) ? values[i][j] : values[i][j + 1];
                            found = true;
                        }
                        else
                        {
                            array[i] = (values[i][j] % 2 != 0) ? values[i][j] : values[i][j + 1];
                            found = true;
                        }
                    }
                    else
                    {
                        if ((values[i][j] % 2 == 0) && (values[i][j + 1] % 2 == 0))
                        {
                            array[i] = (values[i][j] > values[i][j + 1]) ? values[i][j] : values[i][j + 1];
                            found = true;
                        }
                        else
                        {
                            array[i] = (values[i][j] % 2 == 0) ? values[i][j] : values[i][j + 1];
                            found = true;
                        }
                    }
                    j = (array[i] == values[i][j]) ? j : j = j + 1;
                }

            }

            for (int i = 0; i < rowLength; i++)
                sum = sum + array[i];

            Console.Write("Path: ");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write(array[i].ToString());
                if (i < rowLength-1)
                {
                    Console.Write(" > ");
                }
            }

            Console.Write("\nSum = " + sum.ToString());
                
            Console.ReadLine();


        }
    }
}


