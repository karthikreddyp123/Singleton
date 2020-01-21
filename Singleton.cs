using System;

namespace Singleton
{
    sealed class Singleton
    {
        static int instanceCounter = 0;
        private static Singleton instance = null;
        private Singleton()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }
        public static Singleton GetInstance
        {
            get
            {
                
                    if (instance == null)
                    {
                        instance = new Singleton();
                        Console.WriteLine("Creating New Insatnce.");
                        return instance;
                    }
                    else
                    {
                        Console.WriteLine("Using Previous Insatnce.");
                        return instance;
                    }
                
            }
        }
        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}
