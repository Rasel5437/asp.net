using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, first, last, middle;
            int [] arr = new int[100];
            Console.WriteLine("Enter the number of elements in array: ");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements: ");

            for (i = 0; i < x; i++)
            {
                string s = Console.ReadLine();
                arr[i] = Int32.Parse(s);
            }
            Console.WriteLine("Enter the search element: ");
            y = Int32.Parse(Console.ReadLine());

            first = 0;
            last = x - 1;

            while (first <= last)
            {
                middle = (first + last) / 2;
                if (y < arr[middle])
                {
                    last = middle - 1;
                }
                else if (y > arr[middle])
                {
                    first = middle + 1;
                }
                else if (y == arr[middle])
                {
                    Console.WriteLine("Element {0} is found at {1} location", y, middle + 1);
                    break;
                }
            }
            if (first > last)
            {
                Console.WriteLine("The elements is not found.");
            }
        }
    }
}
