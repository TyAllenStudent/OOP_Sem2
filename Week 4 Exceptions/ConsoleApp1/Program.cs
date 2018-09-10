using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //
                int n = int.Parse(Console.ReadLine());

                int sum = 0;

                if (n < 0)
                {
                    throw new ZeroException();
                }

                if (n > 15)
                {
                    throw new FifteenException();
                }

                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                Console.WriteLine(sum);

                Console.ReadKey();

                //Alternate algorithm 

                    //string number = Console.ReadLine();
                    //int sum = 0;
                    //string singleDigit = "";
                    //for (int i = 0; i < number.Length; i++)
                    //{
                    //    singleDigit = number.Substring(i, 1);
                    //    sum += int.Parse(singleDigit);

                    //}
                    //Console.WriteLine(sum);
                    //Console.ReadKey();


                    //int.Parse(number);
                    //Console.WriteLine();
                    //Console.ReadKey();
                    //throw new exc();
            }
            catch (ZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FifteenException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class FormatException : Exception
    {
        public FormatException() : base("should be an integar" + DateTime.Now)
        {

        }

    }

    public class ZeroException : Exception
    {
        public ZeroException() : base("should be a positive integer " + DateTime.Now)
        {

        }

    }

    public class FifteenException : Exception
    {
        public FifteenException() : base("should be less than fifteen " + DateTime.Now)
        {

        }

    }
}
