using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.Singleton
{
    // Once instance 
    /*
        Data repository
        ObjectFactory

        constructor is expensive 
        we only do it once
        we provide everyone with same instance
         
         */
    class Singleton
    {
    }

    interface IDataBase
    {
        int GetPopulation(string name);
    }

    

    class Database : IDataBase
    {
        private static  Lazy<Database>  instance = new  Lazy<Database>(() => new Database());
        public static Database Instance => instance.Value;


        private Dictionary<string, int> capitals;

        private Database(){
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }

}
