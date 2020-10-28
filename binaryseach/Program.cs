using System;

namespace binaryseach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr = { 2, 3, 4, 10, 40 };
          
            int x = 10;

            int result = BinarySearch(arr, 0, arr.Length-1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);

        }
        public static int BinarySearch(int[] arr, int left, int right, int x)
        {
            if(left<= right)
            {
                int mid = left + (right - left) / 2;
                if(x==arr[mid])
                {
                    return mid;
                }
                else if(x < arr[mid])
                {
                    return BinarySearch(arr, left, mid - 1, x);
                }
                else if(x > arr[mid])
                {
                    return BinarySearch(arr, mid+1, right, x);
                }

            }
            return -1;
        }
    }
}
