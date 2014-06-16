using System;
using System.Collections.Generic;

namespace Ex16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Cat> cats = new List<Cat>();
                cats.Add(new Cat());
                cats.Add(new Cat());
                cats.Add(new Cat());

                for (int index = 0; index <= 3; index++)
                {
                    // index == 3 throws an 
                    cats[index].Age = index + 2;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Argument out of range exception thrown - no cat at that index.");
            }
            catch
            {
                Console.WriteLine("Exception occured whilst computing cats.");
            }
            finally
            {
                Console.WriteLine("Deallocating cats...");
            }
        }
    }
}
