using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Algorithms
{
    class FindMissingNumbers
    {
        public void Main()
        {
            var arreglo = new int[]
            {
                3,2,8,6,7,4,1,10
            };


           var numbers = FindNumbers(arreglo);

            Console.WriteLine("numbers missing {0} {1}" , numbers.Item1,numbers.Item2);
        }

        public (int, int) FindNumbers(int[] arr)
        {
            int size = arr.Length + 2;
            long totalSum = (size * size - 1) / 2;
            long sumArr = 0;

            for (int i = 0; i < arr.Length; i++)
                sumArr += arr[i];

            int pivot =(int)( totalSum - sumArr);

            return (0,0);
           
        }



    }
}
