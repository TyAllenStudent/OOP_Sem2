using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unit_Testing.Tests
{
    [TestFixture]
    class UnitTestingTests
    {
        [TestCase]
        int FibocacciRec(int num1, int num2, int numFibs)
        {
            if (numFibs > 0)
            {
                numFibs--;
                num2 = num1 + num2;
                return FibocacciRec(num2, num2 + num1, numFibs);

                
            }

            Console.WriteLine(numFibs);

            return num2 + num1;
            
        }
        
    }
}
