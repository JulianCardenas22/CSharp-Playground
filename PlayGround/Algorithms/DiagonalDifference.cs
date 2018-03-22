using PlayGround.Helps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Algorithms
{
    class DiagonalDiference
    {

        public DiagonalDiference()        {
 
            var array = CreateArray(3);

            Help.PrintIt(array);

            var values = GetDiagonalValues(array);


            var abs = GetDifference(values.Item1, values.Item2);
            Console.WriteLine(abs);
        }

        public  int[,]  CreateArray(int number){
            var a = new Random();
            int[,] array = new int[number,number];
          
            for (int i = 0; i < number; i++){
                for (int j = 0; j < number; j++){
                    array[i,j] = a.Next(10);
                }
            }
            return array;
        }

        public (int,int) GetDiagonalValues(int[,] values)        {

            int limit = values.GetLength(0);
            int primary = 0 , secondary = 0;
          
            for (int i = 0; i < limit; i++){
                for (int j = 0; j < limit; j++){
                    if (i == j)
                        primary += values[i, j];
                    if (j == (limit-1) - i)
                        secondary += values[i,j];
                }
            }
            Console.WriteLine("Primary: {0} Secondary: {1}", primary, secondary);
            return (primary,secondary);
        }


        public int GetDifference(int principal, int secondary)
        {
            return Math.Abs(secondary - principal);
        }
    }
}
