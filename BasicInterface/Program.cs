using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicInterface.File;
using BasicInterface.Interfaces;

namespace BasicInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new USBDriver();
            var test2 = new SerialDriver(123);
            var test3 = new IniFile();
            var test4 = new CSV("Testing file path");
            var message1 = Help.Open(test4);
            var message2 = Help.Read(test3);
            var message3 = Help.Calc(test2);
            Console.Write(message1 + "\n");
            Console.Write(message2 + "\n");
            Console.Write(message3);
            Console.ReadKey();
            
        }
    }
    static class Help
    {
        public static string Open(IAccess a)
        {
            return a.Open();
        }
        public static string Read(IAccess a)
        {
            return a.Read();
        }

        public static string Calc(ITest a)
        {
            return a.calc();
        }
    }
}
