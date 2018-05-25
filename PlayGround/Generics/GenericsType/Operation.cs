using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.GenericsType
{
   public class AddOperation : IOperation
    {
      public double Operation(int a, int b)
        {
            return a + b;
        }
        
    }
  
}
