using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern.Model
{
    public class SingletonClass
    {
        //principle of singleton pattern you ought create  an object, and make the constructor private to the class not be instantiated
        private static SingletonClass instance = new SingletonClass();
        private SingletonClass() { }

        public static SingletonClass getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
