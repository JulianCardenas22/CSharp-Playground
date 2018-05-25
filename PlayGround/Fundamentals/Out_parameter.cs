using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Fundamentals
{
    class Out_parameter
    {

        public void MainOut()
        {
            Console.WriteLine("Write Something : ");
            string message;
            UseOutParameter(out message);
            Console.WriteLine("Message =" + message);
        }

        private bool UseOutParameter(out string message)
        {
          

          
            if (!String.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                message = " nice";
                return true;
            }

            message = "not nice";
            return false;
        }
    }
}
