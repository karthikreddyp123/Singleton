using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(String[] args)
        {
            Singleton DataBaseConnection1 = Singleton.GetInstance;
            DataBaseConnection1.LogMessage("Connection to Database");
            Singleton DataBaseConnection2 = Singleton.GetInstance;
            DataBaseConnection2.LogMessage("Connection to Database");
            if(DataBaseConnection1== DataBaseConnection2)
            {
                Console.WriteLine("Both instances are same.");
            }
        }
    }
}
