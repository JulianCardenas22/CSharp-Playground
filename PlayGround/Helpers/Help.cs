using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.Helpers
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
    }
}
