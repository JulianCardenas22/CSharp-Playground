using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlayGround.Json
{
  public static  class JsonToCsv
  {
    public static void ToCsv(string json)
    {


    }


        public static string ToJsonString<T>(this T arg ) where T: class
        {
          return  JsonConvert.SerializeObject(arg);
        }






    }
}
