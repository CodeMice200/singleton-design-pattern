using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            Console.WriteLine("An instance has been created");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null )
            {
                _instance= new Singleton();
            }
            return _instance;
        }
    }
}
