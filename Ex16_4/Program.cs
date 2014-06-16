using System;
using System.Collections.Generic;

namespace Ex16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int NumberOfCats = 5;
                List<Cat> cats = new List<Cat>();
                var random = new Random();
                for (int index = 0; index < NumberOfCats; index++)
                {
                    var cat = new Cat();
                    cat.Age = random.Next(-5, 5);
                    cats.Add(cat);
                }

                // Check age of cats.
                foreach (var cat in cats)
                {
                    if (cat.Age <= 0)
                    {
                        throw new CustomCatError(String.Format("Age {0} is less than or equal to zero", cat.Age));
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Argument out of range exception thrown - no cat at that index.");
            }
            catch (CustomCatError e)
            {
                Console.WriteLine(e.Message);
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
