using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Helps
{
    class Help
    {
        public static int TextLength(object o)
        {
            Console.WriteLine($"Task with id {Task.CurrentId} processing object {o}...");
            return o.ToString().Length;
        }

        public static void WriteCharacter(char c)
        {
            int i = 10;

            while (i-- > 0)
            {
                Console.Write(c);
            }
        }

        public static void WriteCharacter(object o)
        {
            int i = 10;

            while (i-- > 0)
            {
                Console.Write(o);
            }
        }

        private static Random rdm = new Random();

        public static int[] GenerateArray(int length)
        {
            var arr = new int[length];

            for (int i = 0; i < length - 1; i++)
            {
                arr[i] = rdm.Next(15);
            }
            return arr;
        }
        public static void PrintIt(IEnumerable collection)
        {
            foreach (var element in collection)
            {
                Console.Write(element + " ,");
            }
        }

        public static void PrintIt(int[,] array)
        {
            var limit = array.GetLength(0);

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public static SortedList<char, int> CreateDictionary(String word)
        {
            var map = new SortedList<char, int>();

            foreach (var character in word)
            {
                if (map.ContainsKey(character))
                {
                    map[character]++;
                }
                else
                {
                    map.Add(character, 1);
                }

            }

            return map;

        }
        public static bool CompareMaps(SortedList<char, int> map, SortedList<char, int> map2)
        {
            return map.SequenceEqual(map2);
        }
    }

}
