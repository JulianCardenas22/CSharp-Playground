using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.GenericsType
{
    class Generic<T>
    {

    }

    public static class Exten
    {

        public static int GetLength<T>(this T source) where T : IEnumerable<char>
        {

            foreach (char item in source)
            {
                Console.WriteLine(item);
            }
            return 1;
        }


        public static IEnumerable<char> Reverse<TSource>(this TSource source) 
          where TSource : IEnumerable<char>
        {
            var builder = new StringBuilder();

            foreach (var character in source)   builder.Insert(0, character);


            return  builder.ToString();
        }



    }

}
