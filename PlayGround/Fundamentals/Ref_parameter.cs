using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Fundamentals
{
    class Ref_parameter
    {
        

       public void  MainRef()
        {

            // Should Init message
            string message = "";
            UseRefParameter( ref  message);
          
            Console.WriteLine("Message = "+ message);
        }

        private bool UseRefParameter(ref string message)
        {

            Console.WriteLine("Write Something : ");
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
