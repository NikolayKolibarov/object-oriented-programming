using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> testGenericList = new GenericList<int>();
            testGenericList.Add(25);
            testGenericList.Add(2222);
            testGenericList.Add(2222);
            testGenericList.Add(2222222);

            List<int> testList = new List<int>();
            testList.Add(25);
            testList.Add(2222);
            testList.Add(225);
            testList.Add(500);

            Console.WriteLine(testGenericList.Max());
            Console.WriteLine(testGenericList.Min());
        }
    }
}
