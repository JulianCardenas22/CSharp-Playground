using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Algorithms
{
    class IntToRoman
    {
        private Dictionary<String, int> RomanNumbers = new Dictionary<string, int>();

        public void InitializeRomanNumbers()
        {
            this.RomanNumbers.Add("I", 1);
            this.RomanNumbers.Add("IV", 10);
            this.RomanNumbers.Add("V", 5);
            this.RomanNumbers.Add("IX", 10);
            this.RomanNumbers.Add("X", 10);
            this.RomanNumbers.Add("XL", 40);
            this.RomanNumbers.Add("L", 50);
            this.RomanNumbers.Add("XC", 90);
            this.RomanNumbers.Add("C", 100);
            this.RomanNumbers.Add("DC", 400);
            this.RomanNumbers.Add("D", 500);
            this.RomanNumbers.Add("CM", 900);
            this.RomanNumbers.Add("M", 1000);

           RomanNumbers = RomanNumbers.OrderByDescending(v => v.Value).ToDictionary(pair => pair.Key , pair => pair.Value);
           
        }

        public void Main()
        {
            InitializeRomanNumbers();

            var roman = ToRoman(19);
        

            Console.WriteLine(roman);

        }

        public String ToRoman(int number)
        {
            if (number > 3999 || number < 1)
                throw new ArgumentOutOfRangeException("Range should be  > 1 and < 4000");

                var M = new String[]{ "", "M", "MM", "MMM" };
                var C = new String[]{ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                var X = new String[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                var I = new String[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            
            return M[number / 1000] + C[(number % 1000) / 100] + X[(number % 100) / 10] + I[number % 10];
       
        }

        



    }
}
