using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6, 8 };

            // Length - property that returns size of the array

            Console.WriteLine("Length of array is: " + numbers.Length);

            // Array.IndexOf() - method that returns position of the element

            Console.WriteLine("Position of 9 is: " + Array.IndexOf(numbers, 9));

            // Array.Clear() - method that clear the value

            Array.Clear(numbers, 0 , 2);
            Console.WriteLine("Effect of Array.Clear() method:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Array.Copy() - method that copy first values

            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Array.Copy() method:");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Array.Sort() - method that sort all values

            Array.Sort(numbers);
            Console.WriteLine("Effect of Array.Sort() method: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Array.Reverse() - method that reverse all values

            Array.Reverse(numbers);
            Console.WriteLine("Effect of Array.Reverse() method: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


          
            Console.ReadKey();
        }
    }

}
