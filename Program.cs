using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] items = {4,54,5,7,4};
            Console.WriteLine(LinearSearch(items, 4));
        }
        /*
        * Returns index of item, or -1 if item is not found.
        */
        static int LinearSearch(int [] items, int target){
            int currentIndex = 0;
            int end = items.Length-1;

            while (end < currentIndex){
                if(items[currentIndex]==target){
                    return currentIndex;
                }
                else{
                    currentIndex++;
                }
            }
            return -1;
        }
    }
}
